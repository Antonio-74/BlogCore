﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccesoData.Migrations
{
    public partial class AgregandoCampoDescripcionEnArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Articulo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Articulo");
        }
    }
}
