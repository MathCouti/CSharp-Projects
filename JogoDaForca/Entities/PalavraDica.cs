using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.Entities
{
    class PalavraDica
    {
        public string Palavra { get; set; }
        public string Dica { get; set; }
        public int sorteio { get; set; }
        public string espaco { get; set; }
        public int Vida { get; set; }
        public string PalvraErrada = "";
        


        List<Dictionary<string, string>> palavraDica = new List<Dictionary<string, string>>
    {
        new Dictionary<string, string> {{"palavra", "gato"},{"dica", "animal de estimação"}},
        new Dictionary<string, string> {{"palavra", "escova de cabelo"},{"dica", "objeto para cuidar dos cabelos"}},
        new Dictionary<string, string> {{"palavra", "Carro"},{"dica", "Meio de transporte"}},
        new Dictionary<string, string> {{"palavra", "Computador"},{"dica", "Ferramenta de trabalho"}},
        new Dictionary<string, string> {{"palavra", "caneca"}, {"dica", "objeto para beber"}},
        new Dictionary<string, string> {{"palavra", "óculos"}, {"dica", "Usado para corrigir um problema"}},
        new Dictionary<string, string> {{"palavra", "bicicleta"}, {"dica", "meio de transporte"}},
        new Dictionary<string, string> {{"palavra", "piano"}, {"dica", "instrumento musical"}},
        new Dictionary<string, string> {{"palavra", "telefone"}, {"dica", "comunicação"}},
        new Dictionary<string, string> {{"palavra", "chave"}, {"dica", "abre e fecha"}},
        new Dictionary<string, string> {{"palavra", "churrasco"}, {"dica", "evento em familia e amigos"}},
        new Dictionary<string, string> {{"palavra", "cachorro"},{"dica", "animal de estimação"}},
        new Dictionary<string, string> {{"palavra", "papagaio"},{"dica", "ave que fala"}},
        new Dictionary<string, string> {{"palavra", "jardim"},{"dica", "flores"}},
        new Dictionary<string, string> {{"palavra", "livro"},{"dica", "Possue várias historias"}},
        new Dictionary<string, string> {{"palavra", "viagem"},{"dica", "Sair de casa"}},
        new Dictionary<string, string> {{"palavra", "praia"},{"dica", "Muita areia"}},
        new Dictionary<string, string> {{"palavra", "futebol"},{"dica", "bola"}},
        new Dictionary<string, string> {{"palavra", "avião"},{"dica", "Meio de transporte"}},
        new Dictionary<string, string> {{"palavra", "coelho"},{"dica", "Gosta de pular"}},
        new Dictionary<string, string> {{"palavra", "montanha"},{"dica", "Escavalavel"}},
        new Dictionary<string, string> {{"palavra", "floresta"},{"dica", "Arvore"}},
        new Dictionary<string, string> {{"palavra", "escola"},{"dica", "Conhecimento"}},
        new Dictionary<string, string> {{"palavra", "camisa"},{"dica", "vestimenta"}},
        new Dictionary<string, string> {{"palavra", "filme"},{"dica", "obra artistica"}},
        new Dictionary<string, string> {{"palavra", "dinheiro"},{"dica", "Moeda"}},
        new Dictionary<string, string> {{"palavra", "chuva"},{"dica", "Natureza"}},
        new Dictionary<string, string> {{"palavra", "guitarra"},{"dica", "Instrumento"}},
        new Dictionary<string, string> {{"palavra", "música"},{"dica", "obra artistica"}},
        new Dictionary<string, string> {{"palavra", "carnaval"},{"dica", "festa"}},
        new Dictionary<string, string> {{"palavra", "sorvete"},{"dica", "doce"}}
    };

        public PalavraDica()
        {
            Random rand = new Random();
            sorteio = rand.Next(0, 31);

            Dictionary<string, string> palavraescolhida = palavraDica[sorteio];
            this.Palavra = palavraescolhida["palavra"];
            this.Dica = palavraescolhida["dica"];
            int tamanho = Palavra.Length;
            this.espaco = new string('_', tamanho);
        }

        public string Tela()
        {
            Console.Clear();
            return "Vida: " + Vida
                + "\nPalavra: " + espaco + " (" + espaco.Length + ")"
                + "\nDica: " + Dica
                + "\nLetras erradas: " + PalvraErrada;
        }


        public void CheckLetra(char letra)
        {
            char[] espacoArray = espaco.ToCharArray();
            if (Palavra.Contains(letra) == true)
            {
                for (int i = 0; i < Palavra.Length; i++)
                {
                    if (Palavra[i] == letra)
                    {
                        espacoArray[i] = letra;

                    }
                }
                string n = new string(espacoArray);
                this.espaco = n;
            }
            else
            {
                Vida--;
                PalvraErrada = PalvraErrada + ", " + letra;
            }
        }

    }
}
