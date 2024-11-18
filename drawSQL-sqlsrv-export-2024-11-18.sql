CREATE TABLE "khabgah"(
    "Tedad_room" INT NOT NULL,
    "Modir_name" NVARCHAR(255) NOT NULL,
    "Khabgah_name" NVARCHAR(255) NOT NULL,
    "Khabgah_id" INT NOT NULL
);
ALTER TABLE
    "khabgah" ADD CONSTRAINT "khabgah_khabgah_id_primary" PRIMARY KEY("Khabgah_id");
CREATE TABLE "student"(
    "Full_name" NVARCHAR(255) NOT NULL,
    "Tarikh_sabt" DATE NOT NULL,
    "Code_meli" BIGINT NOT NULL,
    "Image" VARBINARY(MAX) NOT NULL,
    "Room_id" INT NOT NULL,
    "Age" INT NOT NULL,
    "Gensiat" NVARCHAR(255) CHECK
        ("Gensiat" IN(N'(' Male '', N'' Female ')')) NOT NULL,
        "Student_id" INT NOT NULL,
        "Telephon" INT NOT NULL
);
CREATE INDEX "student_code_meli_index" ON
    "student"("Code_meli");
CREATE UNIQUE INDEX "student_room_id_unique" ON
    "student"("Room_id");
ALTER TABLE
    "student" ADD CONSTRAINT "student_student_id_primary" PRIMARY KEY("Student_id");
CREATE TABLE "Rooms"(
    "Room_id" INT NOT NULL,
    "Zarfiat" INT NOT NULL,
    "Khabgah_id" NVARCHAR(255) NOT NULL,
    "Zarfiat_eshghal_shode" INT NOT NULL DEFAULT '0'
);
ALTER TABLE
    "Rooms" ADD CONSTRAINT "rooms_room_id_primary" PRIMARY KEY("Room_id");
CREATE UNIQUE INDEX "rooms_khabgah_id_unique" ON
    "Rooms"("Khabgah_id");
ALTER TABLE
    "student" ADD CONSTRAINT "student_room_id_foreign" FOREIGN KEY("Room_id") REFERENCES "Rooms"("Room_id");
ALTER TABLE
    "Rooms" ADD CONSTRAINT "rooms_khabgah_id_foreign" FOREIGN KEY("Khabgah_id") REFERENCES "khabgah"("Khabgah_id");