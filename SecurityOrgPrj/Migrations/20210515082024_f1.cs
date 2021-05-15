using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SecurityOrgPrj.Migrations
{
    public partial class f1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountriesId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: false),
                    CountriesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Country_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Country",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customer_Name = table.Column<string>(type: "text", nullable: true),
                    Custome_Surname = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecurityOrganization",
                columns: table => new
                {
                    SecurityOrganizationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOrganization = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CountEmployees = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityOrganization", x => x.SecurityOrganizationId);
                    table.ForeignKey(
                        name: "FK_SecurityOrganization_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameCommand = table.Column<string>(type: "text", nullable: false),
                    CountPeople = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    SecurityOrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => new { x.ServiceId, x.SecurityOrganizationId });
                    table.ForeignKey(
                        name: "FK_Service_SecurityOrganization_SecurityOrganizationId",
                        column: x => x.SecurityOrganizationId,
                        principalTable: "SecurityOrganization",
                        principalColumn: "SecurityOrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    ServiceSecurityOrganizationId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    StartSubscription = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndtSubscription = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => new { x.SubscriptionId, x.ServiceId, x.ServiceSecurityOrganizationId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_Subscription_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscription_Service_ServiceId_ServiceSecurityOrganizationId",
                        columns: x => new { x.ServiceId, x.ServiceSecurityOrganizationId },
                        principalTable: "Service",
                        principalColumns: new[] { "ServiceId", "SecurityOrganizationId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionServiceId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionServiceSecurityOrganizationId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionCustomerId = table.Column<int>(type: "integer", nullable: false),
                    Event_Type = table.Column<string>(type: "text", nullable: false),
                    Time_call = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Priority = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => new { x.EventsId, x.SubscriptionId, x.SubscriptionServiceId, x.SubscriptionServiceSecurityOrganizationId, x.SubscriptionCustomerId });
                    table.ForeignKey(
                        name: "FK_Events_Subscription_SubscriptionId_SubscriptionServiceId_Su~",
                        columns: x => new { x.SubscriptionId, x.SubscriptionServiceId, x.SubscriptionServiceSecurityOrganizationId, x.SubscriptionCustomerId },
                        principalTable: "Subscription",
                        principalColumns: new[] { "SubscriptionId", "ServiceId", "ServiceSecurityOrganizationId", "CustomerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeparutureInfo",
                columns: table => new
                {
                    DeparutureInfoId = table.Column<int>(type: "integer", nullable: false),
                    EventsId = table.Column<int>(type: "integer", nullable: false),
                    EventsSubscriptionId = table.Column<int>(type: "integer", nullable: false),
                    EventsSubscriptionServiceId = table.Column<int>(type: "integer", nullable: false),
                    EventsSubscriptionServiceSecurityOrganizationId = table.Column<int>(type: "integer", nullable: false),
                    EventsSubscriptionCustomerId = table.Column<int>(type: "integer", nullable: false),
                    StaffId = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    DepartureTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeparutureInfo", x => new { x.DeparutureInfoId, x.EventsId, x.EventsSubscriptionId, x.EventsSubscriptionServiceId, x.EventsSubscriptionServiceSecurityOrganizationId, x.EventsSubscriptionCustomerId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_DeparutureInfo_Events_EventsId_EventsSubscriptionId_EventsS~",
                        columns: x => new { x.EventsId, x.EventsSubscriptionId, x.EventsSubscriptionServiceId, x.EventsSubscriptionServiceSecurityOrganizationId, x.EventsSubscriptionCustomerId },
                        principalTable: "Events",
                        principalColumns: new[] { "EventsId", "SubscriptionId", "SubscriptionServiceId", "SubscriptionServiceSecurityOrganizationId", "SubscriptionCustomerId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeparutureInfo_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountriesId",
                table: "City",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityId",
                table: "Customer",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DeparutureInfo_DeparutureInfoId",
                table: "DeparutureInfo",
                column: "DeparutureInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeparutureInfo_EventsId_EventsSubscriptionId_EventsSubscrip~",
                table: "DeparutureInfo",
                columns: new[] { "EventsId", "EventsSubscriptionId", "EventsSubscriptionServiceId", "EventsSubscriptionServiceSecurityOrganizationId", "EventsSubscriptionCustomerId" });

            migrationBuilder.CreateIndex(
                name: "IX_DeparutureInfo_StaffId",
                table: "DeparutureInfo",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventsId",
                table: "Events",
                column: "EventsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_SubscriptionId_SubscriptionServiceId_SubscriptionSer~",
                table: "Events",
                columns: new[] { "SubscriptionId", "SubscriptionServiceId", "SubscriptionServiceSecurityOrganizationId", "SubscriptionCustomerId" });

            migrationBuilder.CreateIndex(
                name: "IX_SecurityOrganization_CityId",
                table: "SecurityOrganization",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_SecurityOrganizationId",
                table: "Service",
                column: "SecurityOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceId",
                table: "Service",
                column: "ServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CityId",
                table: "Staff",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_CustomerId",
                table: "Subscription",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_ServiceId_ServiceSecurityOrganizationId",
                table: "Subscription",
                columns: new[] { "ServiceId", "ServiceSecurityOrganizationId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeparutureInfo");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "SecurityOrganization");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
