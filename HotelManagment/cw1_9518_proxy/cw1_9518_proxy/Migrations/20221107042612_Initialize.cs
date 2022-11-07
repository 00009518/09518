using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cw1_9518_proxy.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Brief", "Floor", "IsAvailable", "Price", "RoomNumber" },
                values: new object[,]
                {
                    { 1, "brief_1", 1, true, 0.76696311821167396, 22 },
                    { 2, "brief_2", 5, false, 0.88668765768315505, 3 },
                    { 3, "brief_3", 6, true, 0.24889493555394437, 8 },
                    { 4, "brief_4", 2, false, 0.86879041345043517, 28 },
                    { 5, "brief_5", 8, true, 0.25784547802205482, 9 },
                    { 6, "brief_6", 4, false, 0.17042370755566127, 19 },
                    { 7, "brief_7", 8, true, 0.28597552837573836, 24 },
                    { 8, "brief_8", 3, false, 0.96934628323475613, 10 },
                    { 9, "brief_9", 6, true, 0.47955751113877765, 1 },
                    { 10, "brief_10", 5, false, 0.079575754786231245, 4 },
                    { 11, "brief_11", 9, true, 0.85463665729940663, 1 },
                    { 12, "brief_12", 9, false, 0.96796510652898482, 12 },
                    { 13, "brief_13", 8, true, 0.67691149353084901, 26 },
                    { 14, "brief_14", 7, false, 0.90530577345663643, 6 },
                    { 15, "brief_15", 7, true, 0.36340254945103179, 2 },
                    { 16, "brief_16", 3, false, 0.60933481461876349, 9 },
                    { 17, "brief_17", 3, true, 0.65941000956701745, 23 },
                    { 18, "brief_18", 4, false, 0.72161574115824079, 23 },
                    { 19, "brief_19", 3, true, 0.82358504260502929, 16 },
                    { 20, "brief_20", 4, false, 0.94381975354982284, 10 },
                    { 21, "brief_21", 2, true, 0.64421689565450069, 27 },
                    { 22, "brief_22", 5, false, 0.19189835978909098, 15 },
                    { 23, "brief_23", 4, true, 0.71470846174872882, 19 },
                    { 24, "brief_24", 4, false, 0.78381983636810626, 29 },
                    { 25, "brief_25", 4, true, 0.37933931012864319, 2 },
                    { 26, "brief_26", 4, false, 0.17156163334379793, 1 },
                    { 27, "brief_27", 4, true, 0.34800023701944027, 26 },
                    { 28, "brief_28", 2, false, 0.22023791644702173, 14 },
                    { 29, "brief_29", 4, true, 0.78676800417937165, 20 },
                    { 30, "brief_30", 9, false, 0.89609204389516295, 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
