USE [KP_2024_Suslov]
GO
/****** Object:  Table [dbo].[Гражданин]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Гражданин](
	[ID_Гражданина] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](60) NOT NULL,
	[Дата_Рождения] [date] NOT NULL,
	[Адрес] [varchar](255) NOT NULL,
	[Телефон] [char](12) NOT NULL,
	[Социальный_Статус] [varchar](40) NULL,
 CONSTRAINT [PK_Граждане] PRIMARY KEY CLUSTERED 
(
	[ID_Гражданина] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Документ]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Документ](
	[ID_Документа] [int] IDENTITY(1,1) NOT NULL,
	[ID_Заявления] [int] NOT NULL,
	[Название] [varchar](100) NOT NULL,
	[Статус_Проверки] [varchar](50) NOT NULL,
	[Скан] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Документы] PRIMARY KEY CLUSTERED 
(
	[ID_Документа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Должность]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Должность](
	[ID_Должности] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Должность] PRIMARY KEY CLUSTERED 
(
	[ID_Должности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Заявление]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заявление](
	[ID_Заявления] [int] IDENTITY(1,1) NOT NULL,
	[ID_Гражданина] [int] NOT NULL,
	[ID_Меры] [int] NOT NULL,
	[Дата_Подачи] [date] NOT NULL,
	[ID_Статус] [int] NOT NULL,
	[Комментарий] [varchar](150) NULL,
 CONSTRAINT [PK_Заявления] PRIMARY KEY CLUSTERED 
(
	[ID_Заявления] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[История_Обработки]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[История_Обработки](
	[ID_Записи] [int] NOT NULL,
	[ID_Заявления] [int] NOT NULL,
	[Дата_Изменения] [datetime] NOT NULL,
	[Новый_Статус] [varchar](50) NOT NULL,
	[ID_Сотрудника] [int] NOT NULL,
 CONSTRAINT [PK_История_Обработки] PRIMARY KEY CLUSTERED 
(
	[ID_Записи] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Мера_Поддержки]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Мера_Поддержки](
	[ID_Меры] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](100) NOT NULL,
	[Описание] [varchar](200) NOT NULL,
	[Условия_Предоставления] [varchar](150) NOT NULL,
	[Срок_Действия] [date] NOT NULL,
 CONSTRAINT [PK_Меры_Поддержки] PRIMARY KEY CLUSTERED 
(
	[ID_Меры] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудник]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудник](
	[ID_Сотрудника] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](60) NOT NULL,
	[ID_Должность] [int] NOT NULL,
	[Уровень_доступа] [nvarchar](1) NOT NULL,
	[Контакт] [varchar](50) NOT NULL,
	[Логин] [nvarchar](30) NOT NULL,
	[Пароль] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Сотрудники] PRIMARY KEY CLUSTERED 
(
	[ID_Сотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Login] UNIQUE NONCLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Статус]    Script Date: 17.03.2025 15:00:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Статус](
	[ID_Статус] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Статус] PRIMARY KEY CLUSTERED 
(
	[ID_Статус] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Документ]  WITH CHECK ADD  CONSTRAINT [FK_Документы_Заявления] FOREIGN KEY([ID_Заявления])
REFERENCES [dbo].[Заявление] ([ID_Заявления])
GO
ALTER TABLE [dbo].[Документ] CHECK CONSTRAINT [FK_Документы_Заявления]
GO
ALTER TABLE [dbo].[Заявление]  WITH CHECK ADD  CONSTRAINT [FK_Заявление_Статус] FOREIGN KEY([ID_Статус])
REFERENCES [dbo].[Статус] ([ID_Статус])
GO
ALTER TABLE [dbo].[Заявление] CHECK CONSTRAINT [FK_Заявление_Статус]
GO
ALTER TABLE [dbo].[Заявление]  WITH CHECK ADD  CONSTRAINT [FK_Заявления_Граждане] FOREIGN KEY([ID_Гражданина])
REFERENCES [dbo].[Гражданин] ([ID_Гражданина])
GO
ALTER TABLE [dbo].[Заявление] CHECK CONSTRAINT [FK_Заявления_Граждане]
GO
ALTER TABLE [dbo].[Заявление]  WITH CHECK ADD  CONSTRAINT [FK_Заявления_Меры_Поддержки] FOREIGN KEY([ID_Меры])
REFERENCES [dbo].[Мера_Поддержки] ([ID_Меры])
GO
ALTER TABLE [dbo].[Заявление] CHECK CONSTRAINT [FK_Заявления_Меры_Поддержки]
GO
ALTER TABLE [dbo].[История_Обработки]  WITH CHECK ADD  CONSTRAINT [FK_История_Обработки_Заявления] FOREIGN KEY([ID_Заявления])
REFERENCES [dbo].[Заявление] ([ID_Заявления])
GO
ALTER TABLE [dbo].[История_Обработки] CHECK CONSTRAINT [FK_История_Обработки_Заявления]
GO
ALTER TABLE [dbo].[История_Обработки]  WITH CHECK ADD  CONSTRAINT [FK_История_Обработки_Сотрудники] FOREIGN KEY([ID_Сотрудника])
REFERENCES [dbo].[Сотрудник] ([ID_Сотрудника])
GO
ALTER TABLE [dbo].[История_Обработки] CHECK CONSTRAINT [FK_История_Обработки_Сотрудники]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK_Сотрудник_Должность1] FOREIGN KEY([ID_Должность])
REFERENCES [dbo].[Должность] ([ID_Должности])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK_Сотрудник_Должность1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор гражданина' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'ID_Гражданина'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Полное имя гражданина' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'ФИО'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата рождения' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'Дата_Рождения'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Адрес проживания' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'Адрес'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Контактный телефон (+7)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'Телефон'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Категория статуса (многодетный, пенсионер и т.д.)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин', @level2type=N'COLUMN',@level2name=N'Социальный_Статус'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Гражданин'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор документа' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Документ', @level2type=N'COLUMN',@level2name=N'ID_Документа'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Связь с таблицей Заявления' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Документ', @level2type=N'COLUMN',@level2name=N'ID_Заявления'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование документа' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Документ', @level2type=N'COLUMN',@level2name=N'Название'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Статус проверки (проверен, не проверен)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Документ', @level2type=N'COLUMN',@level2name=N'Статус_Проверки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор заявления' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'ID_Заявления'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Связь с таблицей Граждане' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'ID_Гражданина'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Связь с таблицей Меры_Поддержки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'ID_Меры'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата подачи заявления' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'Дата_Подачи'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Статус заявления (на рассмотрении, одобрено, отклонено)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'ID_Статус'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Комментарии или замечания' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Заявление', @level2type=N'COLUMN',@level2name=N'Комментарий'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор записи' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'История_Обработки', @level2type=N'COLUMN',@level2name=N'ID_Записи'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Связь с таблицей Заявления' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'История_Обработки', @level2type=N'COLUMN',@level2name=N'ID_Заявления'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата и время изменения' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'История_Обработки', @level2type=N'COLUMN',@level2name=N'Дата_Изменения'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Новый статус' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'История_Обработки', @level2type=N'COLUMN',@level2name=N'Новый_Статус'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Кто изменил' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'История_Обработки', @level2type=N'COLUMN',@level2name=N'ID_Сотрудника'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор меры поддержки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Мера_Поддержки', @level2type=N'COLUMN',@level2name=N'ID_Меры'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование меры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Мера_Поддержки', @level2type=N'COLUMN',@level2name=N'Название'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Краткое описание меры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Мера_Поддержки', @level2type=N'COLUMN',@level2name=N'Описание'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Условия предоставления мер поддержки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Мера_Поддержки', @level2type=N'COLUMN',@level2name=N'Условия_Предоставления'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Срок действия меры' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Мера_Поддержки', @level2type=N'COLUMN',@level2name=N'Срок_Действия'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор сотрудника' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Сотрудник', @level2type=N'COLUMN',@level2name=N'ID_Сотрудника'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Полное имя сотрудника' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Сотрудник', @level2type=N'COLUMN',@level2name=N'ФИО'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Должность сотрудника' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Сотрудник', @level2type=N'COLUMN',@level2name=N'Уровень_доступа'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Контактный телефон или email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Сотрудник', @level2type=N'COLUMN',@level2name=N'Контакт'
GO
