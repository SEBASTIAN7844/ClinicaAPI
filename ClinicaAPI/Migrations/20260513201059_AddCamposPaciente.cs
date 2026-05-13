using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CorreoElectronico",
                table: "Pacientes",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Pacientes",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Pacientes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Pacientes",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorreoElectronico",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Pacientes");
        }
    }
}
