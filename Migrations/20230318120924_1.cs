using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GP.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anular",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anular", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inscipciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contrayente1nombre = table.Column<string>(name: "contrayente_1_nombre", type: "nvarchar(max)", nullable: false),
                    contrayente1apellido1 = table.Column<string>(name: "contrayente_1_apellido_1", type: "nvarchar(max)", nullable: false),
                    contrayente1apellido2 = table.Column<string>(name: "contrayente_1_apellido_2", type: "nvarchar(max)", nullable: false),
                    madrecontrayente1nombre = table.Column<string>(name: "madre_contrayente_1_nombre", type: "nvarchar(max)", nullable: false),
                    madrecontrayente1apellido1 = table.Column<string>(name: "madre_contrayente_1_apellido_1", type: "nvarchar(max)", nullable: false),
                    madrecontrayente1apellido2 = table.Column<string>(name: "madre_contrayente_1_apellido_2", type: "nvarchar(max)", nullable: false),
                    padrecontrayente1nombre = table.Column<string>(name: "padre_contrayente_1_nombre", type: "nvarchar(max)", nullable: false),
                    padrecontrayente1apellido1 = table.Column<string>(name: "padre_contrayente_1_apellido_1", type: "nvarchar(max)", nullable: false),
                    padrecontrayente1apellido2 = table.Column<string>(name: "padre_contrayente_1_apellido_2", type: "nvarchar(max)", nullable: false),
                    fechanacimientocontrayente1 = table.Column<DateTime>(name: "fecha_nacimiento_contrayente_1", type: "datetime2", nullable: false),
                    municipionacimientocontrayente1 = table.Column<string>(name: "municipio_nacimiento_contrayente_1", type: "nvarchar(max)", nullable: false),
                    provincianacimientocontrayente1 = table.Column<string>(name: "provincia_nacimiento_contrayente_1", type: "nvarchar(max)", nullable: false),
                    observacionescontrayente1 = table.Column<string>(name: "observaciones_contrayente_1", type: "nvarchar(max)", nullable: false),
                    contrayente2nombre = table.Column<string>(name: "contrayente_2_nombre", type: "nvarchar(max)", nullable: false),
                    contrayente2apellido1 = table.Column<string>(name: "contrayente_2_apellido_1", type: "nvarchar(max)", nullable: false),
                    contrayente2apellido2 = table.Column<string>(name: "contrayente_2_apellido_2", type: "nvarchar(max)", nullable: false),
                    madrecontrayente2nombre = table.Column<string>(name: "madre_contrayente_2_nombre", type: "nvarchar(max)", nullable: false),
                    madrecontrayente2apellido1 = table.Column<string>(name: "madre_contrayente_2_apellido_1", type: "nvarchar(max)", nullable: false),
                    madrecontrayente2apellido2 = table.Column<string>(name: "madre_contrayente_2_apellido_2", type: "nvarchar(max)", nullable: false),
                    padrecontrayente2nombre = table.Column<string>(name: "padre_contrayente_2_nombre", type: "nvarchar(max)", nullable: false),
                    padrecontrayente2apellido1 = table.Column<string>(name: "padre_contrayente_2_apellido_1", type: "nvarchar(max)", nullable: false),
                    padrecontrayente2apellido2 = table.Column<string>(name: "padre_contrayente_2_apellido_2", type: "nvarchar(max)", nullable: false),
                    fechanacimientocontrayente2 = table.Column<DateTime>(name: "fecha_nacimiento_contrayente_2", type: "datetime2", nullable: false),
                    municipionacimientocontrayente2 = table.Column<string>(name: "municipio_nacimiento_contrayente_2", type: "nvarchar(max)", nullable: false),
                    provincianacimientocontrayente2 = table.Column<string>(name: "provincia_nacimiento_contrayente_2", type: "nvarchar(max)", nullable: false),
                    observacionescontrayente2 = table.Column<string>(name: "observaciones_contrayente_2", type: "nvarchar(max)", nullable: false),
                    fechainscripcionmatrimonio = table.Column<DateTime>(name: "fecha_inscripcion_matrimonio", type: "datetime2", nullable: false),
                    codigoreferencia = table.Column<string>(name: "codigo_referencia", type: "nvarchar(max)", nullable: false),
                    tomo = table.Column<int>(type: "int", nullable: false),
                    folio = table.Column<int>(type: "int", nullable: false),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provincia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscipciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "matrimonios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idmatrimonio = table.Column<int>(name: "id_matrimonio", type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idinscripion = table.Column<int>(name: "id_inscripion", type: "int", nullable: false),
                    idtramite = table.Column<int>(name: "id_tramite", type: "int", nullable: false),
                    idanulacion = table.Column<int>(name: "id_anulacion", type: "int", nullable: false),
                    idreferencia = table.Column<string>(name: "id_referencia", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matrimonios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "solicitar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solicitar", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anular");

            migrationBuilder.DropTable(
                name: "inscipciones");

            migrationBuilder.DropTable(
                name: "matrimonios");

            migrationBuilder.DropTable(
                name: "solicitar");
        }
    }
}
