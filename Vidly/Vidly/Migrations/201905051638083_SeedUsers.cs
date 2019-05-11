namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7335755e-f7a9-40c6-af46-9143119d95de', N'guest@vidly.com', 0, N'AFp+SiSP/WbO+0nYsea572o1xlZWFXroUThb0RFHpwSvuQGMfzwbYgVgZHN/Nefh/g==', N'688bb959-96e8-493f-9b5d-df5d992301c5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c16cb002-f8be-4e12-ad97-0229b23a423e', N'admin@vidly.com', 0, N'ANNMYULNy0OLFXQA6F+ZXF67YmD8J003Aw5MSFcr2o8fTn9l0dxJBoS+/E798q3VcA==', N'00eee7ca-f7b0-4fd9-b8a8-91c2140889a9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd74e9747-43d3-49c5-957b-3c7633b6d686', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c16cb002-f8be-4e12-ad97-0229b23a423e', N'd74e9747-43d3-49c5-957b-3c7633b6d686')

");
        }

        public override void Down()
        {
        }
    }
}
