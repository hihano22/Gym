# Gym
# Exam
# Login + Reset Password + Sign in
# Visual Studio 2019
# Database_name: gymmanagement
# Tables: TaiKhoan==>> 
CREATE TABLE [dbo].[TaiKhoan] (
    [TenTaiKhoan] NCHAR (24) NOT NULL,
    [MatKhau]     NCHAR (24) NOT NULL,
    [Email]       NCHAR (26) NOT NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([TenTaiKhoan] ASC)
);