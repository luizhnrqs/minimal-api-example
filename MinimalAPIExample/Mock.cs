using Microsoft.EntityFrameworkCore;
using MinimalAPIExample.Models;

namespace MinimalAPIExample
{
    public class Mock
    {
        public static void Configurar(InMemoryDbContext context)
        {
            context.Herois.Add(new Heroi
            {
                Id = 1,
                Nome = "Homem Aranha",
                Inimigo = "Duende Verde",
                Poder = "Força, Agilidade, Velocidade e Resistência Sobre-Humana, Aderência Física, Reflexos-sobrehumanos, Sentidos-sobrehumanos",
                Especie = "Humano",
                TerraNatal = "Queens, New York",
                Codinome = "Amigo da Vizinhança"
            });

            context.Herois.Add(new Heroi
            {
                Id = 2,
                Nome = "Wolverine",
                Inimigo = "Dentes de Sabre",
                Poder = "Fator de cura regenerativo",
                Especie = "Humano Mutante",
                TerraNatal = "Cold Lake, Alberta, Canada",
                Codinome = "Logan, É o Loga"
            });

            context.Herois.Add(new Heroi
            {
                Id = 3,
                Nome = "Batman",
                Inimigo = "Coringa",
                Poder = "Dinheiro",
                Especie = "Humano",
                TerraNatal = "Gotham City, New York",
                Codinome = "Cavaleiro das Trevas"
            });

            context.Herois.Add(new Heroi
            {
                Id = 4,
                Nome = "Homem de Ferro",
                Inimigo = "Mandarim",
                Poder = "Dinheiro",
                Especie = "Humano",
                TerraNatal = "Sófia, Bulgaria",
                Codinome = "Alcoólatra de ferro, Vingador Dourado"
            });

            context.Herois.Add(new Heroi
            {
                Id = 5,
                Nome = "Mulher Maravilha",
                Inimigo = "Ares",
                Poder = "Super-força, Agilidade sobre-humana, Durabilidade extrema, Fator de cura regenerativo",
                Especie = "Humano",
                TerraNatal = "Lower East Side, New York",
                Codinome = "Capitão"
            });

            context.Herois.Add(new Heroi
            {
                Id = 6,
                Nome = "Capitão América",
                Inimigo = "Caveira Vermelha",
                Poder = "Soro do supersoldado",
                Especie = "Humano",
                TerraNatal = "Lower East Side, New York",
                Codinome = "Capitão"
            });

            context.Herois.Add(new Heroi
            {
                Id = 7,
                Nome = "Super Choque",
                Inimigo = "Raio de Fogo",
                Poder = "Eletricidade",
                Especie = "Humano",
                TerraNatal = "Dakota, EUA",
                Codinome = "Virgil"
            });

            context.SaveChanges();
        }

        public static void Configurar(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Heroi>().HasData(
                new Heroi
                {
                    Id = 1,
                    Nome = "Homem Aranha",
                    Inimigo = "Duende Verde",
                    Poder = "Força, Agilidade, Velocidade e Resistência Sobre-Humana, Aderência Física, Reflexos-sobrehumanos, Sentidos-sobrehumanos",
                    Especie = "Humano",
                    TerraNatal = "Queens, New York",
                    Codinome = "Amigo da Vizinhança"
                },
                new Heroi
                {
                    Id = 2,
                    Nome = "Wolverine",
                    Inimigo = "Dentes de Sabre",
                    Poder = "Fator de cura regenerativo",
                    Especie = "Humano Mutante",
                    TerraNatal = "Cold Lake, Alberta, Canada",
                    Codinome = "Logan, É o Loga"
                },
                new Heroi
                {
                    Id = 3,
                    Nome = "Batman",
                    Inimigo = "Coringa",
                    Poder = "Dinheiro",
                    Especie = "Humano",
                    TerraNatal = "Gotham City, New York",
                    Codinome = "Cavaleiro das Trevas"
                },
                new Heroi
                {
                    Id = 4,
                    Nome = "Homem de Ferro",
                    Inimigo = "Mandarim",
                    Poder = "Dinheiro",
                    Especie = "Humano",
                    TerraNatal = "Sófia, Bulgaria",
                    Codinome = "Alcoólatra de ferro, Vingador Dourado"
                },
                new Heroi
                {
                    Id = 5,
                    Nome = "Mulher Maravilha",
                    Inimigo = "Ares",
                    Poder = "Super-força, Agilidade sobre-humana, Durabilidade extrema, Fator de cura regenerativo",
                    Especie = "Humano",
                    TerraNatal = "Lower East Side, New York",
                    Codinome = "Capitão"
                },
                new Heroi
                {
                    Id = 6,
                    Nome = "Capitão América",
                    Inimigo = "Caveira Vermelha",
                    Poder = "Soro do supersoldado",
                    Especie = "Humano",
                    TerraNatal = "Lower East Side, New York",
                    Codinome = "Capitão"
                },
                new Heroi
                {
                    Id = 7,
                    Nome = "Super Choque",
                    Inimigo = "Raio de Fogo",
                    Poder = "Eletricidade",
                    Especie = "Humano",
                    TerraNatal = "Dakota, EUA",
                    Codinome = "Virgil"
                });
        }
    }
}
