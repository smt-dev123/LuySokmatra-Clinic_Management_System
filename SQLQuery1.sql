USE HMSDB_AU

CREATE TABLE tbl_doctors(
	doctor_id BIGINT PRIMARY KEY IDENTITY,
	doctor_name NVARCHAR (250),
	gender NVARCHAR (50),
	phone NVARCHAR (35),
	specialist NVARCHAR (MAX),
	address NVARCHAR (250),
	profile IMAGE,
	status NVARCHAR (250),
)

SELECT * FROM tbl_rooms
SELECT * FROM tbl_doctors