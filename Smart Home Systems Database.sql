USE [master]
GO
/****** Object:  Database [SmartHomeSystem]    Script Date: 2020/04/29 11:36:52 ******/
CREATE DATABASE [SmartHomeSystem]
GO
ALTER DATABASE [SmartHomeSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartHomeSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartHomeSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartHomeSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartHomeSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SmartHomeSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SmartHomeSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartHomeSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartHomeSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmartHomeSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SmartHomeSystem] SET QUERY_STORE = OFF
GO
USE [SmartHomeSystem]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[ContactInfo] [int] NULL,
	[Gender] [char](1) NOT NULL,
	[Passwords] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfigSettings]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfigSettings](
	[ConfigID] [int] IDENTITY(1,1) NOT NULL,
	[EnergyID] [int] NULL,
	[ConvID] [int] NULL,
	[SafetyID] [int] NULL,
	[ConfigurationType] [varchar](50) NULL,
	[ConfigurationDescription] [varchar](50) NULL,
	[ConfigurationDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConvenienceDepartment]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvenienceDepartment](
	[ConvID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentDescription] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ConvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developer]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developer](
	[DevID] [int] IDENTITY(1,1) NOT NULL,
	[DeverloperFirstName] [varchar](50) NULL,
	[DeverloperLastName] [varchar](50) NULL,
	[Age] [int] NULL,
	[Contact] [int] NULL,
	[Email] [varchar](50) NULL,
	[Speciality] [varchar](50) NULL,
	[Descriptions] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DevID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnergyDepartment]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnergyDepartment](
	[EnergyID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentDescription] [varchar](50) NULL,
	[maintainTemperature] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EnergyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[OrderQty] [int] NOT NULL,
	[UnitPrice] [money] NULL,
	[UnitPriceDiscount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [int] NULL,
	[RevisionNumber] [varchar](15) NULL,
	[OrderDate] [date] NULL,
	[BillToAddressID] [char](10) NOT NULL,
	[ShipAddressID] [char](10) NOT NULL,
	[ShipMethod] [varchar](30) NOT NULL,
	[SubTotal] [int] NOT NULL,
	[TaxAmt] [money] NULL,
	[Freight] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhyicalAddress]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhyicalAddress](
	[AddID] [int] IDENTITY(1,1) NOT NULL,
	[PhyAddress] [varchar](30) NULL,
	[Email] [varchar](50) NULL,
	[City] [varchar](30) NOT NULL,
	[Province] [varchar](30) NOT NULL,
	[Country] [varchar](30) NOT NULL,
	[PostalCode] [char](4) NOT NULL,
	[ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[DevID] [int] NULL,
	[ConfigID] [int] NULL,
	[TechID] [int] NULL,
	[Model] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SafetyDepartment]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SafetyDepartment](
	[SafetyID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentDescription] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SafetyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Technical]    Script Date: 2020/04/29 11:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technical](
	[TechID] [int] IDENTITY(1,1) NOT NULL,
	[TechnicianFirstName] [varchar](50) NULL,
	[TechnicianLastName] [varchar](50) NULL,
	[Age] [int] NULL,
	[Contact] [int] NULL,
	[Email] [varchar](50) NULL,
	[Speciality] [varchar](50) NULL,
	[Descriptions] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TechID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID], [FirstName], [LastName], [Age], [ContactInfo], [Gender], [Passwords]) VALUES (2, N'Vince', N'Moyo', 20, 794241341, N'm', N'123')
INSERT [dbo].[Client] ([ID], [FirstName], [LastName], [Age], [ContactInfo], [Gender], [Passwords]) VALUES (3, N'ryan ', N'james', 30, 948253428, N'm', N'123')
INSERT [dbo].[Client] ([ID], [FirstName], [LastName], [Age], [ContactInfo], [Gender], [Passwords]) VALUES (4, N'sarah', N'chetty', 23, 234523452, N'f', N'321')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[ConfigSettings] ON 

INSERT [dbo].[ConfigSettings] ([ConfigID], [EnergyID], [ConvID], [SafetyID], [ConfigurationType], [ConfigurationDescription], [ConfigurationDate]) VALUES (1, 1, 1, 1, N'Premium', N'all modes are activeted', CAST(N'2020-01-12' AS Date))
INSERT [dbo].[ConfigSettings] ([ConfigID], [EnergyID], [ConvID], [SafetyID], [ConfigurationType], [ConfigurationDescription], [ConfigurationDate]) VALUES (2, 2, 2, 2, N'Compact', N'some modes actived', CAST(N'2020-05-23' AS Date))
INSERT [dbo].[ConfigSettings] ([ConfigID], [EnergyID], [ConvID], [SafetyID], [ConfigurationType], [ConfigurationDescription], [ConfigurationDate]) VALUES (3, 3, 3, 3, N'Basic', N'free modes actived', CAST(N'2019-03-16' AS Date))
SET IDENTITY_INSERT [dbo].[ConfigSettings] OFF
GO
SET IDENTITY_INSERT [dbo].[ConvenienceDepartment] ON 

INSERT [dbo].[ConvenienceDepartment] ([ConvID], [ComponentDescription]) VALUES (1, N'defrost food')
INSERT [dbo].[ConvenienceDepartment] ([ConvID], [ComponentDescription]) VALUES (2, N'cook food')
INSERT [dbo].[ConvenienceDepartment] ([ConvID], [ComponentDescription]) VALUES (3, N'play music')
SET IDENTITY_INSERT [dbo].[ConvenienceDepartment] OFF
GO
SET IDENTITY_INSERT [dbo].[Developer] ON 

INSERT [dbo].[Developer] ([DevID], [DeverloperFirstName], [DeverloperLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (1, N'george', N'phala', 20, 23452345, N'pabalo@gmail.com', N'C# developer', N'build systems ')
INSERT [dbo].[Developer] ([DevID], [DeverloperFirstName], [DeverloperLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (2, N'elvis', N'koko', 24, 23453423, N'pass@gmail.com', N'systems tester', N'test and grade systems')
INSERT [dbo].[Developer] ([DevID], [DeverloperFirstName], [DeverloperLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (3, N'jack', N'daniels', 33, 34523345, N'brandy@gmail.com', N'full stack developer', N'ingtegration systems')
SET IDENTITY_INSERT [dbo].[Developer] OFF
GO
SET IDENTITY_INSERT [dbo].[EnergyDepartment] ON 

INSERT [dbo].[EnergyDepartment] ([EnergyID], [ComponentDescription], [maintainTemperature]) VALUES (1, N'solar', N'23 degress')
INSERT [dbo].[EnergyDepartment] ([EnergyID], [ComponentDescription], [maintainTemperature]) VALUES (2, N'wind', N'20 degress')
INSERT [dbo].[EnergyDepartment] ([EnergyID], [ComponentDescription], [maintainTemperature]) VALUES (3, N'battery', N'40 degress')
SET IDENTITY_INSERT [dbo].[EnergyDepartment] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [OrderQty], [UnitPrice], [UnitPriceDiscount]) VALUES (1, 1, 3, 54, 34.0000, 12.0000)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [OrderQty], [UnitPrice], [UnitPriceDiscount]) VALUES (3, 3, 4, 453, 23.0000, 3.0000)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [OrderQty], [UnitPrice], [UnitPriceDiscount]) VALUES (4, 4, 5, 23, 56.0000, 76.0000)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [ID], [RevisionNumber], [OrderDate], [BillToAddressID], [ShipAddressID], [ShipMethod], [SubTotal], [TaxAmt], [Freight]) VALUES (1, 2, N'34', CAST(N'2020-12-01' AS Date), N'12        ', N'34345     ', N'pacific', 200, 12.0000, N'12b')
INSERT [dbo].[Orders] ([OrderID], [ID], [RevisionNumber], [OrderDate], [BillToAddressID], [ShipAddressID], [ShipMethod], [SubTotal], [TaxAmt], [Freight]) VALUES (3, 3, N'45', CAST(N'2020-02-23' AS Date), N'34        ', N'4524      ', N'atlantic', 421, 2.0000, N'34g')
INSERT [dbo].[Orders] ([OrderID], [ID], [RevisionNumber], [OrderDate], [BillToAddressID], [ShipAddressID], [ShipMethod], [SubTotal], [TaxAmt], [Freight]) VALUES (4, 4, N'23', CAST(N'2017-11-09' AS Date), N'65        ', N'1234      ', N'atlantic', 234, 1.0000, N'43b')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[PhyicalAddress] ON 

INSERT [dbo].[PhyicalAddress] ([AddID], [PhyAddress], [Email], [City], [Province], [Country], [PostalCode], [ID]) VALUES (1, N'17th avenue', N'zamub@gmail.com', N'Pretoria', N'Gauteng', N'South Africa', N'1515', 2)
INSERT [dbo].[PhyicalAddress] ([AddID], [PhyAddress], [Email], [City], [Province], [Country], [PostalCode], [ID]) VALUES (2, N'45 raven street', N'asrfsdf@gamil.com', N'Boksburg', N'Gauteng', N'South Africa', N'2014', 3)
INSERT [dbo].[PhyicalAddress] ([AddID], [PhyAddress], [Email], [City], [Province], [Country], [PostalCode], [ID]) VALUES (3, N'12 black road', N'ergeef@gmail.com', N'Polokwane', N'Limpopo', N'South Africa', N'4231', 4)
SET IDENTITY_INSERT [dbo].[PhyicalAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [DevID], [ConfigID], [TechID], [Model]) VALUES (3, N'Premium', 3, 2, 1, 23)
INSERT [dbo].[Products] ([ProductID], [ProductName], [DevID], [ConfigID], [TechID], [Model]) VALUES (4, N'Compact', 1, 3, 2, 432)
INSERT [dbo].[Products] ([ProductID], [ProductName], [DevID], [ConfigID], [TechID], [Model]) VALUES (5, N'Basic', 3, 1, 2, 452)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[SafetyDepartment] ON 

INSERT [dbo].[SafetyDepartment] ([SafetyID], [ComponentDescription]) VALUES (1, N'security cameras')
INSERT [dbo].[SafetyDepartment] ([SafetyID], [ComponentDescription]) VALUES (2, N'sensors')
INSERT [dbo].[SafetyDepartment] ([SafetyID], [ComponentDescription]) VALUES (3, N'alarms')
SET IDENTITY_INSERT [dbo].[SafetyDepartment] OFF
GO
SET IDENTITY_INSERT [dbo].[Technical] ON 

INSERT [dbo].[Technical] ([TechID], [TechnicianFirstName], [TechnicianLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (1, N'sam', N'smith', 29, 345234523, N'asfaev@gmail.com', N'Energy component', N'installation of energy components')
INSERT [dbo].[Technical] ([TechID], [TechnicianFirstName], [TechnicianLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (2, N'johhny', N'van zyl', 32, 423452345, N'adidas@gmail.com', N'Safety components', N'updates cameras')
INSERT [dbo].[Technical] ([TechID], [TechnicianFirstName], [TechnicianLastName], [Age], [Contact], [Email], [Speciality], [Descriptions]) VALUES (3, N'thabo', N'nkoeng', 19, 234524542, N'ezacul@gmail.com', N'convenience', N'updates cooking applications')
SET IDENTITY_INSERT [dbo].[Technical] OFF
GO
ALTER TABLE [dbo].[ConfigSettings]  WITH CHECK ADD FOREIGN KEY([ConvID])
REFERENCES [dbo].[ConvenienceDepartment] ([ConvID])
GO
ALTER TABLE [dbo].[ConfigSettings]  WITH CHECK ADD FOREIGN KEY([EnergyID])
REFERENCES [dbo].[EnergyDepartment] ([EnergyID])
GO
ALTER TABLE [dbo].[ConfigSettings]  WITH CHECK ADD FOREIGN KEY([SafetyID])
REFERENCES [dbo].[SafetyDepartment] ([SafetyID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[PhyicalAddress]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ConfigID])
REFERENCES [dbo].[ConfigSettings] ([ConfigID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([DevID])
REFERENCES [dbo].[Developer] ([DevID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([TechID])
REFERENCES [dbo].[Technical] ([TechID])
GO
USE [master]
GO
ALTER DATABASE [SmartHomeSystem] SET  READ_WRITE 
GO
