using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NuevoCodigo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Capacitaciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Inscripciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 11, 16, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 11, 26, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 11, 26, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 57, 14, 618, DateTimeKind.Local).AddTicks(8804));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Inscripciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Capacitaciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 29, 20, 19, 10, 908, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 8, 20, 19, 10, 908, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 8, 20, 19, 10, 908, DateTimeKind.Local).AddTicks(6799) });
        }
    }
}
