CREATE TABLE holidays (
  ID int IDENTITY(1,1) PRIMARY KEY,
  holiday_date nvarchar(15) NOT NULL,
  holiday_name_group nvarchar(45) DEFAULT NULL,
  holiday_name_en nvarchar(55) DEFAULT NULL,
  holiday_name_vi nvarchar(55) COLLATE Latin1_General_100_CI_AI_SC_UTF8,
  remark nvarchar(55) DEFAULT NULL,
  updated_by nvarchar(55) DEFAULT NULL,
  updated_date DATETIME NULL DEFAULT CURRENT_TIMESTAMP
  
);


INSERT INTO holidays VALUES 
('2021-01-01','NewYear2021','New Year 2021','Tết Dương Lịch 2021','',NULL,'2021-02-05 01:46:08'),
('2021-02-10','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2021-02-11','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2021-02-12','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2021-02-13','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2021-02-14','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2021-02-15','LunaNewYear2021','Luna New Year 2021','Nghỉ Tết Nguyên Đán 2021',NULL,NULL,'2021-02-05 01:48:59'),
('2022-01-01','NewYear2022','New Year 2022','Tết Dương Lịch 2021',NULL,NULL,'2021-05-18 04:43:46'),
('2022-01-31','LunaNewYear2022','Luna New Year 2022','Nghỉ Tết Nguyên Đán 2022',NULL,NULL,'2021-05-18 04:43:46'),
('2022-02-01','LunaNewYear2022','Luna New Year 2022','Nghỉ Tết Nguyên Đán 2022',NULL,NULL,'2021-05-18 04:43:46'),
('2022-02-02','LunaNewYear2022','Luna New Year 2022','Nghỉ Tết Nguyên Đán 2022',NULL,NULL,'2021-05-18 04:43:46'),
('2022-02-03','LunaNewYear2022','Luna New Year 2022','Nghỉ Tết Nguyên Đán 2022',NULL,NULL,'2021-05-18 04:43:46'),
('2022-02-04','LunaNewYear2022','Luna New Year 2022','Nghỉ Tết Nguyên Đán 2022',NULL,NULL,'2021-05-18 04:43:46'),
('2021-09-02','NationalDay2021','National Day 2021','Quốc Khánh 2021',NULL,NULL,'2021-05-18 04:45:36'),
('2022-09-02','NationalDay2022','National Day 2022','Quốc Khánh 2022',NULL,NULL,'2021-05-18 04:46:04'),
('2022-04-30','LiberationDay2022','Liberation Day 2022','Ngày Giải phóng',NULL,NULL,'2021-05-18 04:54:35'),
('2022-05-02','InternationalLaborDay2022','International Labor Day 2022','Ngày Quốc tế Lao động','Bù ngày Quốc tế LĐ 2022-05-01',NULL,'2021-05-18 04:54:35'),
('2022-04-11','HungVuongKing2022','Hung Vuong King anniversary 2022','Giỗ tổ Hùng Vương','Bù ngày giỗ tổ ngày 2022-04-10',NULL,'2021-05-18 04:57:17'),
('2022-09-01','NationalDay2022','National Day 2022','Quốc Khánh 2022',NULL,NULL,'2022-03-14 04:09:08'),
('2023-01-02','NewYear2023','New Year 2023','Tết Dương Lịch 2023','Bù Tết Dương lịch 01 (chủ nhật)',NULL,'2022-11-21 06:54:30'),
('2023-01-23','LunaNewYear2023','Luna New Year 2023','Nghỉ Tết Nguyên Đán 2023','Nghỉ từ 21 den 25-01-2023, bu 26-01-2023',NULL,'2022-11-21 06:54:30'),
('2023-01-24','LunaNewYear2023','Luna New Year 2023','Nghỉ Tết Nguyên Đán 2023','Nghỉ từ 21 den 25-01-2023, bu 26-01-2023',NULL,'2022-11-21 06:54:30'),
('2023-01-25','LunaNewYear2023','Luna New Year 2023','Nghỉ Tết Nguyên Đán 2023','Nghỉ từ 21 den 25-01-2023, bu 26-01-2023',NULL,'2022-11-21 06:54:30'),
('2023-01-26','LunaNewYear2023','Luna New Year 2023','Nghỉ Tết Nguyên Đán 2023','Nghỉ từ 21 den 25-01-2023, bu 26-01-2023',NULL,'2022-11-21 06:54:30'),
('2023-04-29','HungVuongKing2023','Hung Vuong King anniversary 2023','Giỗ tổ Hùng Vương',NULL,NULL,'2022-11-25 06:58:10'),
('2023-05-01','InternationalLaborDay2023','International Labor Day 2023','Ngày Quốc tế Lao động',NULL,NULL,'2022-11-25 06:58:10'),
('2023-05-02','LiberationDay2023','Liberation Day 2023','Ngày Giải phóng','Bù ngày Ngày Giải phóng 2023-04-30 (thứ 7)',NULL,'2022-11-25 06:58:10'),
('2023-09-04','NationalDay2023','National Day 2023','Quốc Khánh 2023','',NULL,'2022-11-25 06:58:10'),
('2023-05-03','LiberationDay2023','Liberation Day 2023','Ngày Giải phóng (Bù)','Bù ngày Ngày Giải phóng 2023-04-30 (thứ 7)',NULL,'2023-04-25 01:26:47'),
('2023-05-08','Trip','Trip','Du lịch công ty',NULL,NULL,'2023-04-25 01:26:47');