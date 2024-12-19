using CSHARP241219;

Book book01 = new(
    title: "Kincskereső Kisködmön",
    authorNames: "Móra Ferenc");

Book book02 = new(
    "A Formal Approach to Game Design and Game Research",
    "Robin Hunicke",
    "Marc LeBlanc",
    "Robert Zubek");

Book book03 = new(
    title: "The Sentinels",
    authorNames: ["Geno Salvatore", "R.A. Salvatore"]);

Console.WriteLine(book01);
Console.WriteLine(book02);
Console.WriteLine(book03);
