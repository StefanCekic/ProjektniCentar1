namespace ProjektniCentar1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c7f9d76-fa97-4ab6-bfea-92bf311416fa', N'Admin@admin.com', 0, N'AMNFSEaWk3slJUkRWmCixpjjUeumAlR3AqBYr8gHHZX4rF37fFj4tbACdMuv/rgcJg==', N'8bba3b36-cd2c-4389-813a-712f3883208e', NULL, 0, 0, NULL, 1, 0, N'Admin@admin.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3413a63-8341-48ed-9525-7d3c1f06c653', N'Viewer@viewer.com', 0, N'APXWVMLvoH6INA3NSLBR+tHD0nQYPmpmJM7DfuniLQYERAqDDQonNdJBC9BkIEtljA==', N'16fe4d2f-a9c5-4e6b-aa69-30765a99f78c', NULL, 0, 0, NULL, 1, 0, N'Viewer@viewer.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd022b2a-cb35-4d2c-b7fa-951ba5c44610', N'Editor@editor.com', 0, N'AKuDQlN4yfKi++DhO092HkckpsuZ7GbheJ3rg5/NWl8tRA2gMyNqzcOZMWowbrKb9g==', N'4b78f92f-43f2-4c83-b55e-671f066ecd03', NULL, 0, 0, NULL, 1, 0, N'Editor@editor.com')
               
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2e862fce-6242-4f25-b531-a6529cc9b74e', N'Admin')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'84995484-fa53-4f41-a593-6163dd267629', N'Editor')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6cbc2a04-a969-4aa3-94e0-b4922350ca6a', N'Viewer')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c7f9d76-fa97-4ab6-bfea-92bf311416fa', N'2e862fce-6242-4f25-b531-a6529cc9b74e')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c3413a63-8341-48ed-9525-7d3c1f06c653', N'6cbc2a04-a969-4aa3-94e0-b4922350ca6a')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cd022b2a-cb35-4d2c-b7fa-951ba5c44610', N'84995484-fa53-4f41-a593-6163dd267629')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
