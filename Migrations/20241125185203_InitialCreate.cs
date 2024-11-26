using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistGestNotas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acudiente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateOnly>(type: "date", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudiente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreGrado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLogro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetalleLogro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoAcademico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePeriodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoAcademico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradoAsignadoId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateOnly>(type: "date", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docentes_Grados_GradoAsignadoId",
                        column: x => x.GradoAsignadoId,
                        principalTable: "Grados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradoActualId = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    AcudienteId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<DateOnly>(type: "date", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Acudiente_AcudienteId",
                        column: x => x.AcudienteId,
                        principalTable: "Acudiente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Grados_GradoActualId",
                        column: x => x.GradoActualId,
                        principalTable: "Grados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boletines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    PeriodoAcademicoId = table.Column<int>(type: "int", nullable: true),
                    LogroAsignadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boletines_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Boletines_Logros_LogroAsignadoId",
                        column: x => x.LogroAsignadoId,
                        principalTable: "Logros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Boletines_PeriodoAcademico_PeriodoAcademicoId",
                        column: x => x.PeriodoAcademicoId,
                        principalTable: "PeriodoAcademico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoletinId = table.Column<int>(type: "int", nullable: true),
                    GradoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Boletines_BoletinId",
                        column: x => x.BoletinId,
                        principalTable: "Boletines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Asignaturas_Grados_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreActividad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaActividad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actividades_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_AsignaturaId",
                table: "Actividades",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_BoletinId",
                table: "Asignaturas",
                column: "BoletinId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_GradoId",
                table: "Asignaturas",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletines_EstudianteId",
                table: "Boletines",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletines_LogroAsignadoId",
                table: "Boletines",
                column: "LogroAsignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletines_PeriodoAcademicoId",
                table: "Boletines",
                column: "PeriodoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_GradoAsignadoId",
                table: "Docentes",
                column: "GradoAsignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_AcudienteId",
                table: "Estudiantes",
                column: "AcudienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_GradoActualId",
                table: "Estudiantes",
                column: "GradoActualId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Boletines");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Logros");

            migrationBuilder.DropTable(
                name: "PeriodoAcademico");

            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Grados");
        }
    }
}
