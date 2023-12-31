USE [FPL_DaoTao2]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 08/04/2023 7:12:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MASV] [nvarchar](50) NULL,
	[Tienganh] [int] NULL,
	[Tinhoc] [int] NULL,
	[GDTC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STUDENTS]    Script Date: 08/04/2023 7:12:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENTS](
	[MASV] [nvarchar](50) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SoDT] [nvarchar](15) NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Hinh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/04/2023 7:12:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD FOREIGN KEY([MASV])
REFERENCES [dbo].[STUDENTS] ([MASV])
GO
/****** Object:  StoredProcedure [dbo].[del_sv]    Script Date: 08/04/2023 7:12:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[del_sv]
@masv nvarchar(50)
as 
begin
	delete Grade where MASV = @masv
	delete STUDENTS where MASV = @masv
end
GO
/****** Object:  StoredProcedure [dbo].[sp_checkLogin]    Script Date: 08/04/2023 7:12:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_checkLogin]
@username nvarchar(50), @password nvarchar(50)
as
begin
select * from Users where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS AND password = @password COLLATE SQL_Latin1_General_CP1_CS_AS
end
GO
