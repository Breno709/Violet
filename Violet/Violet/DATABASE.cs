using System;
using System.Collections.Generic;
using System.Text;

namespace Violet
{
    static public class DATABASE
    {
        static public List<Registro> Registros = new List<Registro>();
        static public Pessoa[] Residentes
        {
            get
            {
                Pessoa[] pessoa =
                {
                    new Pessoa("Sophia Pereira Barbosa","(35) 3735-4384","SophiaPereiraBarbosa@dayrep.com","Rua Alfi Del Sarto, 509 Poços de Caldas-MG","37713-190"),
                    new Pessoa("Gabrielle Gomes Sousa", "(62) 4693-4353", "GabrielleGomesSousa@armyspy.com", "Rua Cirilo Silva, 522 Anápolis-GO", "75120-030"),
                    new Pessoa("Vitória Castro Azevedo", "(43) 7818-8919", "VitoriaCastroAzevedo@teleworm.us", "Rua Regência, 1045 Cambé-PR", "86192-590"),
                    new Pessoa("Leila Melo Lima", "(91) 9982-5703", "LeilaMeloLima@armyspy.com", "Vila Torres, 1407 Belém-PA", "66085-660"),
                    new Pessoa("Júlia Souza Costa", "(61) 8461-8339", "JuliaSouzaCosta@armyspy.com", "Quadra QI 10 Conjunto J, 1980 Guará-DF", "71010-107"),
                    new Pessoa("Bruna Alves Almeida", "(48) 7664-7677", "BrunaAlvesAlmeida@dayrep.com", "Rua Treze de Maio, 1395 São José-SC", "88110-035"),
                    new Pessoa("Isabela Azevedo Cunha", "(98) 9515-3592", "IsabelaAzevedoCunha@dayrep.com", "Travessa Professor Nascimento Moraes, 1294 São Luís-MA", "65080-340"),
                    new Pessoa("Beatrice Souza Almeida", "(11) 9614-2482", "BeatriceSouzaAlmeida@jourrapide.com", "Rua Chico Xavier, 1097 Francisco Morato-SP", "07934-150")
                };

                return pessoa;
            }
        }

    }
}
