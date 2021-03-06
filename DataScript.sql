USE[AlbumsProject]

delete from [dbo].[ChatGroupToUsers]
delete from [dbo].[ChatGroups];
delete from [dbo].[Comments];
delete from [dbo].[Posts];
delete from [dbo].[AspNetUsers];

SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (1, 0, N'668c4e1c-e58d-4fa1-9f31-50d8aa1f7c21', N'erasmus@iisi.pcz.pl', 0, 1, NULL, N'ERASMUSK@IISI.PCZ.PL', N'ERASMUS@IISI.PCZ.PL', N'AQAAAAEAACcQAAAAEFLPcl88Z7zWdPZWL0JMO8LcC0H6cvvNSU8EYkS2+ZVnJv9sH0AL1v/s5KETvBrepw==', NULL, 0, N'08c20bd5-da34-4f56-8107-c463837818ad', 0, N'erasmus@iisi.pcz.pl')
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (2, 0, N'668c4e1c-e58d-4fa1-9f31-50d8aa1f7c21', N'erasmus2@iisi.pcz.pl', 0, 1, NULL, N'ERASMUS2@IISI.PCZ.PL', N'ERASMUS2@IISI.PCZ.PL', N'AQAAAAEAACcQAAAAEFLPcl88Z7zWdPZWL0JMO8LcC0H6cvvNSU8EYkS2+ZVnJv9sH0AL1v/s5KETvBrepw==', NULL, 0, N'08c20bd5-da34-4f56-8107-c463837818ad', 0, N'erasmus2@iisi.pcz.pl')
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
GO

SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([Id], [AuthorId], [Content], [Title],[Date]) VALUES (1, 1, N'This is first post of John Smith', N'First post', '2017-10-22')
INSERT [dbo].[Posts] ([Id], [AuthorId], [Content], [Title],[Date]) VALUES (2, 2, N'This blog is awesome :) ', N'Awesome blog','2017-10-25')
INSERT [dbo].[Posts] ([Id], [AuthorId], [Content], [Title],[Date]) VALUES (3, 2, N'What do think about new .NET core framework ?', N'.NET Core ?', '2017-11-01')
SET IDENTITY_INSERT [dbo].[Posts] OFF
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [AuthorId], [PostId], [Text]) VALUES (1, 1, 2, N'It''s true')
INSERT [dbo].[Comments] ([Id], [AuthorId], [PostId], [Text]) VALUES (2, 1, 2, N'Thanks')
SET IDENTITY_INSERT [dbo].[Comments] OFF
SET IDENTITY_INSERT [dbo].[ChatGroups] ON 

INSERT [dbo].[ChatGroups] ([Id], [Name]) VALUES (1, N'AIP')
INSERT [dbo].[ChatGroups] ([Id], [Name]) VALUES (2, N'A')
INSERT [dbo].[ChatGroups] ([Id], [Name]) VALUES (3, N'B')
SET IDENTITY_INSERT [dbo].[ChatGroups] OFF


INSERT [dbo].[ChatGroupToUsers] ([ChatGroupId], [UserId]) VALUES (1, 1)
INSERT [dbo].[ChatGroupToUsers] ([ChatGroupId], [UserId]) VALUES (2, 1)

INSERT [dbo].[ChatGroupToUsers] ([ChatGroupId], [UserId]) VALUES (2, 2)
INSERT [dbo].[ChatGroupToUsers] ([ChatGroupId], [UserId]) VALUES (3, 2)




