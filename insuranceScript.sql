USE [master]
GO
/****** Object:  Database [InsuranceDB]    Script Date: 1/6/2021 5:59:56 PM ******/
CREATE DATABASE [InsuranceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InsuranceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\InsuranceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InsuranceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\InsuranceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [InsuranceDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InsuranceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InsuranceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InsuranceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InsuranceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InsuranceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InsuranceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [InsuranceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InsuranceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InsuranceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InsuranceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InsuranceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InsuranceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InsuranceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InsuranceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InsuranceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InsuranceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InsuranceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InsuranceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InsuranceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InsuranceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InsuranceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InsuranceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InsuranceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InsuranceDB] SET RECOVERY FULL 
GO
ALTER DATABASE [InsuranceDB] SET  MULTI_USER 
GO
ALTER DATABASE [InsuranceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InsuranceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InsuranceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InsuranceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InsuranceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InsuranceDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'InsuranceDB', N'ON'
GO
ALTER DATABASE [InsuranceDB] SET QUERY_STORE = OFF
GO
USE [InsuranceDB]
GO
/****** Object:  UserDefinedFunction [dbo].[SV_GetAmountByPrice]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[SV_GetAmountByPrice]
(
	@Amount int
)

RETURNS int
AS
BEGIN

	RETURN (SELECT customerID FROM dbo.Payment WHERE (amount>@Amount))

END
GO
/****** Object:  Table [dbo].[Claim]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Claim](
	[claimID] [int] NOT NULL,
	[customerID] [int] NOT NULL,
	[policyNo] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[status] [varchar](255) NOT NULL,
	[issued_by] [varchar](255) NOT NULL,
	[issued_date] [date] NOT NULL,
 CONSTRAINT [PK_Claim] PRIMARY KEY CLUSTERED 
(
	[claimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[paymentID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[policyNo] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[paymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Claim_vs_Payment]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Claim_vs_Payment]
AS
SELECT dbo.Claim.customerID, dbo.Claim.claimID, dbo.Claim.policyNo, dbo.Claim.amount, dbo.Claim.status, dbo.Claim.issued_by, dbo.Claim.issued_date, dbo.Payment.paymentID, dbo.Payment.date
FROM     dbo.Claim CROSS JOIN
                  dbo.Payment
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] NOT NULL,
	[NIC] [int] NOT NULL,
	[DOB] [date] NOT NULL,
	[religion] [varchar](255) NOT NULL,
	[nationality] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policy]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policy](
	[policyNo] [int] NOT NULL,
	[customerID] [int] NOT NULL,
	[agentCode] [int] NOT NULL,
	[type] [varchar](255) NOT NULL,
	[monthly_premium] [decimal](10, 2) NOT NULL,
	[annual_premium] [decimal](10, 2) NOT NULL,
	[hospital_plan] [decimal](10, 2) NOT NULL,
	[critical_illness_cover] [decimal](10, 2) NOT NULL,
	[accident_death_cover] [decimal](10, 2) NOT NULL,
	[natural_death_cover] [decimal](10, 2) NOT NULL,
	[opened_age] [int] NOT NULL,
	[start_date] [date] NOT NULL,
	[end_date] [date] NOT NULL,
	[maturity_money] [decimal](10, 2) NOT NULL,
	[duration] [int] NOT NULL,
 CONSTRAINT [PK_Policy] PRIMARY KEY CLUSTERED 
(
	[policyNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Customer_vs_Policy]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Customer_vs_Policy]
AS
SELECT dbo.Customer.customerID, dbo.Customer.DOB, dbo.Policy.policyNo, dbo.Policy.type, dbo.Policy.annual_premium, dbo.Policy.start_date, dbo.Policy.end_date, dbo.Policy.maturity_money
FROM     dbo.Customer INNER JOIN
                  dbo.Policy ON dbo.Customer.customerID = dbo.Policy.customerID
GO
/****** Object:  UserDefinedFunction [dbo].[TV_PaymentsByCustomer]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[TV_PaymentsByCustomer]
(	
	@CustomerID int
)
RETURNS TABLE 
AS
RETURN 
(
	
	SELECT * FROM Payment WHERE (customerID = @CustomerID)
)
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[NIC] [int] NOT NULL,
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[NIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agent]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agent](
	[agentCode] [int] NOT NULL,
	[NIC] [int] NOT NULL,
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Agent] PRIMARY KEY CLUSTERED 
(
	[agentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[NIC] [int] NOT NULL,
	[name_with_initials] [varchar](255) NOT NULL,
	[address] [varchar](255) NOT NULL,
	[gender] [varchar](255) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[NIC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userMobile]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userMobile](
	[NIC] [int] NOT NULL,
	[mobile] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_User] FOREIGN KEY([NIC])
REFERENCES [dbo].[User] ([NIC])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_User]
GO
ALTER TABLE [dbo].[Agent]  WITH CHECK ADD  CONSTRAINT [FK_Agent_User] FOREIGN KEY([NIC])
REFERENCES [dbo].[User] ([NIC])
GO
ALTER TABLE [dbo].[Agent] CHECK CONSTRAINT [FK_Agent_User]
GO
ALTER TABLE [dbo].[Claim]  WITH CHECK ADD  CONSTRAINT [FK_Claim_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Claim] CHECK CONSTRAINT [FK_Claim_Customer]
GO
ALTER TABLE [dbo].[Claim]  WITH NOCHECK ADD  CONSTRAINT [FK_Claim_Policy] FOREIGN KEY([policyNo])
REFERENCES [dbo].[Policy] ([policyNo])
GO
ALTER TABLE [dbo].[Claim] CHECK CONSTRAINT [FK_Claim_Policy]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_User] FOREIGN KEY([NIC])
REFERENCES [dbo].[User] ([NIC])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_User]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Customer]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Policy] FOREIGN KEY([policyNo])
REFERENCES [dbo].[Policy] ([policyNo])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Policy]
GO
ALTER TABLE [dbo].[Policy]  WITH NOCHECK ADD  CONSTRAINT [FK_Policy_Agent] FOREIGN KEY([agentCode])
REFERENCES [dbo].[Agent] ([agentCode])
GO
ALTER TABLE [dbo].[Policy] CHECK CONSTRAINT [FK_Policy_Agent]
GO
ALTER TABLE [dbo].[Policy]  WITH CHECK ADD  CONSTRAINT [FK_Policy_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Policy] CHECK CONSTRAINT [FK_Policy_Customer]
GO
ALTER TABLE [dbo].[userMobile]  WITH CHECK ADD  CONSTRAINT [FK_userMobile_User] FOREIGN KEY([NIC])
REFERENCES [dbo].[User] ([NIC])
GO
ALTER TABLE [dbo].[userMobile] CHECK CONSTRAINT [FK_userMobile_User]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetClaimsByCustomer]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetClaimsByCustomer]
	@CustomerID int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT claimID, policyNo, amount, issued_date FROM Claim WHERE (customerID=@CustomerID)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCustomersByAgent]    Script Date: 1/6/2021 5:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetCustomersByAgent]
	@AgentCode int
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT customerID, policyNo, type, annual_premium, start_date, duration FROM Policy WHERE (agentCode = @AgentCode)

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[35] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Claim"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 252
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Payment"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 197
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Claim_vs_Payment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Claim_vs_Payment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[30] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Customer"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 218
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Policy"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 394
               Right = 519
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1800
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Customer_vs_Policy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Customer_vs_Policy'
GO
USE [master]
GO
ALTER DATABASE [InsuranceDB] SET  READ_WRITE 
GO
