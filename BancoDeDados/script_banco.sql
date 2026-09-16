BANCO DE DADOS (SCRIPT, TABELAS E INSERTS [100% COMPLETO])

USE [master]
GO
/****** Object:  Database [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446]    Script Date: 07/10/2024 21:34:01 ******/
CREATE DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446]
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446', FILENAME = N'C:\Users\israel.fbatista\PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON
( NAME = N'PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446_log', FILENAME = N'C:\Users\israel.fbatista\PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ARITHABORT OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET AUTO_CLOSE ON
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET  ENABLE_BROKER
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET READ_COMMITTED_SNAPSHOT ON
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET  MULTI_USER
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET DB_CHAINING OFF
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET QUERY_STORE = OFF
GO
USE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/10/2024 21:34:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
    [MigrationId] [nvarchar](150) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED
(
    [MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 07/10/2024 21:34:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
    [IdCurso] [int] IDENTITY(1,1) NOT NULL,
    [NomeCurso] [varchar](50) NOT NULL,
    [DescricaoCurso] [varchar](500) NOT NULL,
    [CargaHrCurso] [varchar](50) NOT NULL,
    [TpCurso] [varchar](50) NOT NULL,
    [ValorCurso] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED
(
    [IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operador]    Script Date: 07/10/2024 21:34:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operador](
    [IdOp] [int] IDENTITY(1,1) NOT NULL,
    [NomeOp] [nvarchar](50) NOT NULL,
    [CpfOp] [nvarchar](14) NOT NULL,
    [EmailOp] [nvarchar](50) NOT NULL,
    [SenhaOp] [nvarchar](12) NOT NULL,
    [IdOperador] [int] NOT NULL,
 CONSTRAINT [PK_Operador] PRIMARY KEY CLUSTERED
(
    [IdOp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/10/2024 21:34:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
    [IdUsuario] [int] IDENTITY(1,1) NOT NULL,
    [NomeUsuario] [nvarchar](50) NOT NULL,
    [TelefoneUsuario] [nvarchar](14) NOT NULL,
    [EmailUsuario] [nvarchar](50) NOT NULL,
    [SenhaUsuario] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED
(
    [IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004004_initialMigration', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004217_seed-Curso', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004421_seed-Aula', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004454_seed-AulaCurso', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004505_seed-Operador', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004516_seed-TipoOperador', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004528_seed-Usuario', N'8.0.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720004536_seed-Venda', N'8.0.7')
GO
SET IDENTITY_INSERT [dbo].[Curso] ON
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (4, N'C#', N'Um curso de C# é uma formação voltada para ensinar a linguagem de programação C#, desenvolvida pela Microsoft. Nele, você aprenderá a criar aplicações, desde programas simples até projetos mais complexos, usando o Visual Studio, uma ferramenta de desenvolvimento popular. O curso cobre os fundamentos da linguagem, como sintaxe, estruturas de controle, e manipulação de dados, além de conceitos mais avançados como orientação a objetos, desenvolvimento de interfaces gráficas e acesso a banco de dado', N'800H', N'Desenvolvimento Back', N'1199')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (5, N'Python', N'Um curso de Python é uma formação destinada a ensinar a linguagem de programação Python, conhecida por sua simplicidade e versatilidade. No curso, você aprenderá desde os conceitos básicos, como sintaxe, variáveis e estruturas de controle, até tópicos avançados como programação orientada a objetos, manipulação de arquivos e desenvolvimento de aplicações web. Além disso, o curso aborda bibliotecas populares como NumPy e pandas para análise de dados, e Django para desenvolvimento web. Ao final, vo', N'360H', N'Desenvolvimento Back', N'1349')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (6, N'Java', N'Um curso de Java é uma formação que ensina a linguagem de programação Java, amplamente utilizada em desenvolvimento de aplicações empresariais, Android e sistemas complexos. Durante o curso, você aprenderá os fundamentos da linguagem, incluindo sintaxe, tipos de dados e estruturas de controle. Além disso, o curso aborda conceitos avançados como programação orientada a objetos, manipulação de exceções, e desenvolvimento de interfaces gráficas com JavaFX. Também são explorados tópicos como acesso ', N'620H', N'Desenvolvimento Back', N'1799')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (8, N'cobol', N'bol', N'180H', N'back', N'1888')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (10, N'php', N'back', N'700h', N'back', N'2199')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (12, N'log', N'logica', N'120h', N'logica', N'899')
GO
INSERT [dbo].[Curso] ([IdCurso], [NomeCurso], [DescricaoCurso], [CargaHrCurso], [TpCurso], [ValorCurso]) VALUES (13, N'drog', N'dur', N'900h', N'rim', N'2111')
GO
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[Operador] ON
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (2, N'Indio Bombado Emo', N'02844576899', N'indiobombadaspicasduras@uol.com', N'bombinha123', 2)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (3, N'Samael Kimaris', N'09188823177', N'samaeldodemonio@diabo.com', N'succubus123', 2)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (4, N'Mongoleison', N'21289145529', N'mongoloide@dur.com', N'deficiente88', 3)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (5, N'Krampus', N'97868122341', N'natalzinho@mamaenoel.com', N'fucknoel111', 3)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (6, N'Cramunhão', N'66652466677', N'coisaruim@domal.com', N'capetinha666', 4)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (7, N'Peixonauta', N'98727254166', N'pop@gostosinha.com', N'eitapop000', 4)
GO
INSERT [dbo].[Operador] ([IdOp], [NomeOp], [CpfOp], [EmailOp], [SenhaOp], [IdOperador]) VALUES (8, N'Macaco Aranha', N'45170800129', N'spider.monkey@ben10.com', N'teiapelocu99', 5)
GO
SET IDENTITY_INSERT [dbo].[Operador] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (2, N'SamuelMonkeypox', N'(119) 649-0979', N'israelfelix@email.com', N'12345')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (4, N'Anderson Prego', N'11987005241', N'andersinho.viadinho@gmail.com', N'ainain000')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (5, N'Luquinhas Come Tijolo', N'11969880031', N'adorotijolo@gmail.com', N'tijoloadoro1')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (7, N'Cleitinho do Balé', N'11978660434', N'sougay.muitogay@gmail.com', N'mecomem44444')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (8, N'Carlinhos', N'11938732651', N'carlinhoscavalos@gmail.com', N'amocavalos81')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (9, N'israel', N'7777777777', N'israel2gmail.com', N'israel123')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (10, N'macaco', N'11987694252', N'macacoel@gmail.com', N'mac@123')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (11, N'negaoBoiola', N'(111) 111-1111', N'negao@email.com', N'Neg123')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (1012, N'luqueta', N'(111) 987-9845', N'luq@gmail.com', N'luq123')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (1013, N'dragon', N'(444) 876-9999', N'dragon@hotmail.com', N'dra123')
GO
INSERT [dbo].[Usuario] ([IdUsuario], [NomeUsuario], [TelefoneUsuario], [EmailUsuario], [SenhaUsuario]) VALUES (1014, N'wil', N'(123) 444-8799', N'wil@cafetao.com', N'wil123')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
/****** Object:  Index [IX_Operador_IdOperador]    Script Date: 07/10/2024 21:34:01 ******/
CREATE NONCLUSTERED INDEX [IX_Operador_IdOperador] ON [dbo].[Operador]
(
    [IdOperador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [PROJETO12345Context-5b98f6b0-fcc0-49f2-a872-b01f7f037446] SET  READ_WRITE
GO