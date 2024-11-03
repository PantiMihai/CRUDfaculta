using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUDfaculta.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "BirthDate", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(1996, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Andrei Popescu", "+40-712-123456" },
                    { 2, 33, new DateTime(1990, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Maria Ionescu", "+40-712-234567" },
                    { 3, 38, new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Ion Vasilescu", "+40-712-345678" },
                    { 4, 31, new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Elena Dumitrescu", "+40-712-456789" },
                    { 5, 35, new DateTime(1988, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Alexandru Stan", "+40-712-567890" },
                    { 6, 29, new DateTime(1994, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Cristina Radulescu", "+40-712-678901" },
                    { 7, 36, new DateTime(1987, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Florin Georgescu", "+40-712-789012" },
                    { 8, 28, new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Ioana Mihai", "+40-712-890123" },
                    { 9, 34, new DateTime(1989, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Radu Marinescu", "+40-712-901234" },
                    { 10, 30, new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Gabriela Olaru", "+40-712-123789" },
                    { 11, 43, new DateTime(1980, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mihai Dobre", "+40-712-234890" },
                    { 12, 32, new DateTime(1991, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Ana Morar", "+40-712-345901" },
                    { 13, 37, new DateTime(1986, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Dragos Barbu", "+40-712-456012" },
                    { 14, 39, new DateTime(1984, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Diana Voinea", "+40-712-567123" },
                    { 15, 33, new DateTime(1990, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "George Petrescu", "+40-712-678234" },
                    { 16, 28, new DateTime(1995, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Adina Roman", "+40-712-789345" },
                    { 17, 30, new DateTime(1993, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Vlad Neagu", "+40-712-890456" },
                    { 18, 31, new DateTime(1992, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Alina Iacob", "+40-712-901567" },
                    { 19, 42, new DateTime(1981, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Bogdan Tudor", "+40-712-123678" },
                    { 20, 34, new DateTime(1989, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Anca Pavel", "+40-712-234789" },
                    { 21, 32, new DateTime(1991, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Cosmin Stanescu", "+40-712-345890" },
                    { 22, 35, new DateTime(1988, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Simona Moraru", "+40-712-456901" },
                    { 23, 44, new DateTime(1979, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Lucian Pavel", "+40-712-567012" },
                    { 24, 29, new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Raluca Balan", "+40-712-678123" },
                    { 25, 37, new DateTime(1986, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Stefan Dumitru", "+40-712-789234" },
                    { 26, 31, new DateTime(1992, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Daniela Ciobanu", "+40-712-890345" },
                    { 27, 40, new DateTime(1983, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Paul Trifan", "+40-712-901456" },
                    { 28, 33, new DateTime(1990, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Madalina Gabor", "+40-712-123567" },
                    { 29, 36, new DateTime(1987, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Nicolae Stefan", "+40-712-234678" },
                    { 30, 30, new DateTime(1993, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Laura Avram", "+40-712-345789" },
                    { 31, 39, new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sorin Radu", "+40-712-456890" },
                    { 32, 27, new DateTime(1996, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Bianca Stancu", "+40-712-567901" },
                    { 33, 34, new DateTime(1989, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Claudiu Ion", "+40-712-678012" },
                    { 34, 28, new DateTime(1995, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Georgiana Pavel", "+40-712-789123" },
                    { 35, 32, new DateTime(1991, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mircea Olteanu", "+40-712-890234" },
                    { 36, 31, new DateTime(1992, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Liliana Nastase", "+40-712-901345" },
                    { 37, 38, new DateTime(1985, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Valentin Cernat", "+40-712-123456" },
                    { 38, 36, new DateTime(1987, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Nicoleta Tanase", "+40-712-234567" },
                    { 39, 29, new DateTime(1994, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sergiu Grosu", "+40-712-345678" },
                    { 40, 37, new DateTime(1986, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Monica Toma", "+40-712-456789" },
                    { 41, 35, new DateTime(1988, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Andrei Marinescu", "+40-712-567890" },
                    { 42, 31, new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Mirela Pavel", "+40-712-678901" },
                    { 43, 36, new DateTime(1987, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Radu Dumitrescu", "+40-712-789012" },
                    { 44, 28, new DateTime(1995, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Gabriela Moldovan", "+40-712-890123" },
                    { 45, 33, new DateTime(1990, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Bogdan Ionescu", "+40-712-901234" },
                    { 46, 30, new DateTime(1993, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Alina Popa", "+40-712-123789" },
                    { 47, 38, new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Mihai Stan", "+40-712-234890" },
                    { 48, 32, new DateTime(1991, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Oana Toma", "+40-712-345901" },
                    { 49, 37, new DateTime(1986, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Cristian Gheorghe", "+40-712-456012" },
                    { 50, 34, new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Elena Radu", "+40-712-567123" },
                    { 51, 31, new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "George Vasilescu", "+40-712-678234" },
                    { 52, 29, new DateTime(1994, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Simona Neagu", "+40-712-789345" },
                    { 53, 35, new DateTime(1988, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Lucian Enache", "+40-712-890456" },
                    { 54, 30, new DateTime(1993, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Daniela Pop", "+40-712-901567" },
                    { 55, 32, new DateTime(1991, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Florin Vasile", "+40-712-123678" },
                    { 56, 34, new DateTime(1989, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Ana Dragan", "+40-712-234789" },
                    { 57, 28, new DateTime(1995, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Rares Constantin", "+40-712-345890" },
                    { 58, 31, new DateTime(1992, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Iulia Nistor", "+40-712-456901" },
                    { 59, 43, new DateTime(1980, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Dorin Luca", "+40-712-567012" },
                    { 60, 29, new DateTime(1994, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Diana Tudor", "+40-712-678123" },
                    { 61, 40, new DateTime(1983, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Adrian Serban", "+40-712-789234" },
                    { 62, 33, new DateTime(1990, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Raluca Petre", "+40-712-890345" },
                    { 63, 38, new DateTime(1985, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sorin Barbu", "+40-712-901456" },
                    { 64, 35, new DateTime(1988, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Oana Radulescu", "+40-712-123567" },
                    { 65, 30, new DateTime(1993, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Ion Balan", "+40-712-234678" },
                    { 66, 32, new DateTime(1991, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Cristina Moraru", "+40-712-345789" },
                    { 67, 33, new DateTime(1990, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Roxana Cojocaru", "+40-712-456890" },
                    { 68, 36, new DateTime(1987, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Mihai Cernat", "+40-712-567901" },
                    { 69, 41, new DateTime(1982, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Valentin Albu", "+40-712-678012" },
                    { 70, 28, new DateTime(1995, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Gabriela Popescu", "+40-712-789123" },
                    { 71, 34, new DateTime(1989, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Paul Mocanu", "+40-712-890234" },
                    { 72, 31, new DateTime(1992, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Liliana Chirila", "+40-712-901345" },
                    { 73, 39, new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Dragos Mihai", "+40-712-123456" },
                    { 74, 37, new DateTime(1986, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Adriana Dumitrescu", "+40-712-234567" },
                    { 75, 32, new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Bogdan Roman", "+40-712-345678" },
                    { 76, 29, new DateTime(1994, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Elena Ciobanu", "+40-712-456789" },
                    { 77, 36, new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "George Stanciu", "+40-712-567890" },
                    { 78, 30, new DateTime(1993, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Silvia Gheorghita", "+40-712-678901" },
                    { 79, 42, new DateTime(1981, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Ionut Avram", "+40-712-789012" },
                    { 80, 28, new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Maria Dima", "+40-712-890123" },
                    { 81, 41, new DateTime(1982, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Stefan Udrea", "+40-712-901234" },
                    { 82, 33, new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Ileana Costea", "+40-712-123789" },
                    { 83, 34, new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Dumitru Grigore", "+40-712-234890" },
                    { 84, 32, new DateTime(1991, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Ana Irimia", "+40-712-345901" },
                    { 85, 38, new DateTime(1985, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Ion Stan", "+40-712-456012" },
                    { 86, 35, new DateTime(1988, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Bianca Lupu", "+40-712-567123" },
                    { 87, 31, new DateTime(1992, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Nicolae Anghel", "+40-712-678234" },
                    { 88, 29, new DateTime(1994, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Anca Albu", "+40-712-789345" },
                    { 89, 37, new DateTime(1986, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Marius Badea", "+40-712-890456" },
                    { 90, 30, new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Eugenia Chiriac", "+40-712-901567" },
                    { 91, 33, new DateTime(1990, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Cosmin Raducanu", "+40-712-123678" },
                    { 92, 28, new DateTime(1995, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Daniela Iliescu", "+40-712-234789" },
                    { 93, 40, new DateTime(1983, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Petre Tomescu", "+40-712-345890" },
                    { 94, 32, new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Lavinia Roman", "+40-712-456901" },
                    { 95, 36, new DateTime(1987, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Stefan Fodor", "+40-712-567012" },
                    { 96, 30, new DateTime(1993, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Ioana Pavel", "+40-712-678123" },
                    { 97, 35, new DateTime(1988, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Octavian Dragu", "+40-712-789234" },
                    { 98, 31, new DateTime(1992, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Nicoleta Banciu", "+40-712-890345" },
                    { 99, 33, new DateTime(1990, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Darius Matei", "+40-712-901456" },
                    { 100, 28, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Larisa Calin", "+40-712-123567" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 100);
        }
    }
}
