using System;
using System.Linq;
using WebProject1.Models;
using WebProject1.Models.Enums;

namespace WebProject1.Data
{
    public class SeedingService
    {

        private WebProject1Context _context;

        public SeedingService(WebProject1Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.Product.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Adventure");
            Department d2 = new Department(2, "Open World");
            Department d3 = new Department(3, "Fighting");
            Department d4 = new Department(4, "RPG");
            Department d5 = new Department(5, "Estrategy");
            Department d6 = new Department(6, "Fantasy");
            Department d7 = new Department(7, "Criminal Case");
            Department d8 = new Department(8, "First Person");
            Department d9 = new Department(9, "Racing");
            Department d10 = new Department(10, "Sports");

            Seller s1 = new Seller(1, "Maurício", 3000.0);
            Seller s2 = new Seller(2, "Christian", 3000.0);
            Seller s3 = new Seller(3, "Rodrigo", 3000.0);

            Product p1 = new Product(001, "Diablo IV", d1,230,"detalhe do jogo");
            Product p2 = new Product(002, "The Last of Us Part I", d5,400,"detalhe do jogo");
            Product p3 = new Product(003, "FIFA 2023", d10, 400, "detalhe do jogo");
            Product p4 = new Product(004, "Horizon Forbidden West", d2, 400, "detalhe do jogo");
            Product p5 = new Product(005, "Pokémon Violet", d2, 400, "detalhe do jogo");
            Product p6 = new Product(006, "Pokémon Scarlet", d2, 400, "detalhe do jogo");
            Product p7 = new Product(007, "Pokémon Legend: Arceus", d6, 400, "detalhe do jogo");
            Product p8 = new Product(008, "Pokémon Sword", d6, 400, "detalhe do jogo");
            Product p9 = new Product(009, "Pokémon Shield", d6, 400, "detalhe do jogo");
            Product p10 = new Product(010, "Star Wars Jedi: Survivor", d2, 400, "detalhe do jogo");
            Product p11 = new Product(011, "God of War Ragnarok", d4, 400, "detalhe do jogo");
            Product p12 = new Product(012, "Hogwarts Legacy", d6, 400, "detalhe do jogo");
            Product p13 = new Product(013, "Call of Duty: Modern Warfare II", d8, 400, "detalhe do jogo");
            Product p14 = new Product(014, "Spider-Man: Miles Morales", d1, 400, "detalhe do jogo");
            Product p15 = new Product(015, "The Last of Us Part II", d5, 400, "detalhe do jogo");
            Product p16 = new Product(016, "Elden Ring", d4, 400, "detalhe do jogo");
            Product p17 = new Product(017, "Gran Turismo 7", d9, 400, "detalhe do jogo");
            Product p18 = new Product(018, "Overwatch 2", d7, 400, "detalhe do jogo");
            Product p19 = new Product(019, "Gran Turismo 7", d9, 400, "detalhe do jogo");
            Product p20 = new Product(020, "Mortal Kombat", d3, 400, "detalhe do jogo");

            SalesRecord r1 = new SalesRecord(1, new DateTime(2023,3,7), 230.0, s1, p1, SaleStatus.Vendido);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2023, 3, 7), 423.0, s1, p19, SaleStatus.Devolvido);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2023, 3, 7), 147.0, s2, p14, SaleStatus.Vendido);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2023, 3,7), 324.0, s2, p2, SaleStatus.Cancelado);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 2, 3), 235.0, s3, p7, SaleStatus.Vendido);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2023, 2, 3), 249.0, s3, p8, SaleStatus.Pendente);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2023, 3, 3), 135.0, s1, p15, SaleStatus.Vendido);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2023, 3, 3), 230.0, s1, p15, SaleStatus.Devolvido);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2023, 3, 3), 233.0, s2, p2, SaleStatus.Cancelado);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2023, 7, 3), 236.0, s2, p3, SaleStatus.Vendido);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2023, 7, 3), 400.0, s3, p16, SaleStatus.Vendido);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2023, 7, 3), 300.0, s3, p13, SaleStatus.Vendido);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2023, 10, 3), 200.0, s1, p12, SaleStatus.Pendente);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2023, 11, 3), 130.0, s1, p3, SaleStatus.Vendido);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2023, 11, 3), 230.0, s2, p4, SaleStatus.Vendido);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2023, 2, 3), 230.0, s2, p5, SaleStatus.Vendido);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2023, 11, 3), 130.0, s3, p5, SaleStatus.Devolvido);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2023, 11, 3), 330.0, s3, p20, SaleStatus.Cancelado);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2023, 9, 3), 430.0, s1, p5, SaleStatus.Vendido);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2023, 11, 3), 130.0, s1, p6, SaleStatus.Pendente);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2023, 8, 3), 220.0, s2, p8, SaleStatus.Vendido);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2023, 9, 3), 350.0, s2, p17, SaleStatus.Vendido);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2023, 3, 3), 220.0, s3, p18, SaleStatus.Vendido);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2023, 1, 3), 210.0, s3, p20, SaleStatus.Vendido);

            _context.Department.AddRange(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10);

            _context.Product.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10,
                                      p11, p12, p13, p14, p15, p16, p17, p18, p19, p20);

            _context.Seller.AddRange(s1, s2, s3);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                                      r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24);

            _context.SaveChanges();
        }
    }
}