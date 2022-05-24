using AppShopping.Libraries.Enums;
using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Services
{
    public class EstablishmentService
    {
        public List<Establishment> GetEstablishment()
        {
            var establishment = new List<Establishment>() {
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/122012/renner_0.png?itok=VvGKSsDe",
                    Name = "Renner",
                    Description = "A Lojas Renner S.A. é uma rede de lojas de departamento brasileira.",
                    Address = "2 Andar - Loja 10/11/12/13/14 - Entrada Norte",
                    Phone = "(61) 3333-3333",
                },
                new Establishment()
                {
                    Id = 2,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052012/samsung.png?itok=Mq0egkoi",
                    Name = "Samsung",
                    Description = "Agora, você tem mais uma opção para experimentar e conhecer os produtos Samsung, antes de tomar a sua decisão de compra. Isso porque, nas Lojas Samsung, você pode manusear celulares, tablets, câmeras, smartphones e notebooks livremente, e ainda conta com consultoria e atendimento de vendedores especializados. A experiência de compra de equipamentos tecnológicos deixa de ser impessoal e ganha um caráter mais assertivo e direcionado ao seu verdadeiro desejo.",
                    Address = "2 Andar - Loja 01/02 - Entrada Norte",
                    Phone = "(61) 3475-2650",
                },
                new Establishment()
                {
                    Id = 3,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052016/logo_chilli_beans_1c.png?itok=w_B1Ywks",
                    Name = "Chilli Beans",
                    Description = "A maior rede brasileira de óculos escuros e acessórios”. Essa definição resume a Chilli Beans: provocativa, ardente e envolvente. É a marca da pimenta. Uma marca que, toda semana, lança novos óculos, novos relógios e novas possibilidades. Ou seja, novas formas de compor seu visual. Com mais de 580 pontos de venda exclusivos no Brasil, Estados Unidos, Portugal, Peru, Colômbia e Kuwait, a Chilli Beans é uma marca diversificada, com uma linha de produtos que inclui, além dos óculos escuros e relógios, armações de óculos de grau e lentes em pontos de vendas exclusivos. Além disso, a marca está por trás de um mundo de ações de patrocínio de festas, shows, esportes e ações sociais",
                    Address = "2 Andar - Loja 03 - Entrada Norte",
                    Phone = "(61) 3475-2744",
                }
            };

            return establishment;
        }
    }
}
