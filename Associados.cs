using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_livros
{
    internal class FrmCadastroDeLivrosObj
    {
        private string _cpf;
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (value.Trim().Length != 11)
                    throw new Exception("O CPF deve conter 11 dígitos");
                _cpf = value;
            }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Por favor, digite o seu nome!");
                _nome = value;
            }
        }
        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (value != "Masculino" && value != "Feminino")
                    throw new Exception("O sexo deve ser 'Feminino' ou 'Masculino'!");
                _sexo = value;
            }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                if (value == null)
                    throw new Exception("Por favor, digite o seu logradouro!");
                _logradouro = value;
            }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set
            {
                if (value == null)
                    throw new Exception("Por favor, digite a sua cidade!");
                _cidade = value;
            }
        }

        private string _estado;

        private static readonly HashSet<string> EstadosBrasileiros = new HashSet<string>
    {
        "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
        "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
        "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí",
        "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia",
        "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"
    };

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (!EstadosBrasileiros.Contains(value))
                    throw new ArgumentException("Estado inválido. Selecione um dos 27 estados brasileiros.");
                _estado = value;
            }
        }
   
        private string _pais;

        // Conjunto contendo os 194 países reconhecidos no mundo
        private static readonly HashSet<string> Paises = new HashSet<string>
    {
        "Afeganistão", "África do Sul", "Albânia", "Alemanha", "Andorra", "Angola", "Antígua e Barbuda",
        "Arábia Saudita", "Argélia", "Argentina", "Armênia", "Austrália", "Áustria", "Azerbaijão",
        "Bahamas", "Bahrein", "Bangladesh", "Barbados", "Bélgica", "Belize", "Benin", "Bermuda",
        "Bielorrússia", "Bolívia", "Bósnia e Herzegovina", "Botsuana", "Brasil", "Brunei", "Bulgária",
        "Burkina Faso", "Burundi", "Butão", "Cabo Verde", "Camarões", "Camboja", "Canadá", "Catar",
        "Cazaquistão", "Chade", "Chile", "China", "Chipre", "Colômbia", "Comores", "Congo-Brazzaville",
        "Congo-Kinshasa", "Coreia do Norte", "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia",
        "Cuba", "Dinamarca", "Djibuti", "Dominica", "Egito", "El Salvador", "Emirados Árabes Unidos",
        "Equador", "Eritreia", "Eslováquia", "Eslovênia", "Espanha", "Estados Unidos", "Estônia",
        "Eswatini", "Etiópia", "Fiji", "Filipinas", "Finlândia", "França", "Gabão", "Gâmbia", "Gana",
        "Geórgia", "Granada", "Grécia", "Guatemala", "Guiana", "Guiné", "Guiné-Bissau", "Haiti", "Honduras",
        "Hungria", "Iémen", "Ilhas Marshall", "Ilhas Salomão", "Índia", "Indonésia", "Irã", "Iraque",
        "Irlanda", "Islândia", "Israel", "Itália", "Jamaica", "Japão", "Jordânia", "Kiribati", "Kuwait",
        "Laos", "Lesoto", "Letônia", "Líbano", "Libéria", "Líbia", "Liechtenstein", "Lituânia",
        "Luxemburgo", "Macedônia do Norte", "Madagáscar", "Malásia", "Maláui", "Maldivas", "Mali", "Malta",
        "Marrocos", "Maurícia", "Mauritânia", "México", "Mianmar", "Micronésia", "Moçambique", "Moldávia",
        "Mônaco", "Mongólia", "Montenegro", "Namíbia", "Nauru", "Nepal", "Nicarágua", "Níger", "Nigéria",
        "Noruega", "Nova Zelândia", "Omã", "Países Baixos", "Palau", "Panamá", "Papua-Nova Guiné",
        "Paquistão", "Paraguai", "Peru", "Polônia", "Portugal", "Quênia", "Quirguistão", "Reino Unido",
        "República Centro-Africana", "República Checa", "República Dominicana", "Romênia", "Ruanda",
        "Rússia", "Samoa", "San Marino", "Santa Lúcia", "São Cristóvão e Neves", "São Tomé e Príncipe",
        "São Vicente e Granadinas", "Seicheles", "Senegal", "Serra Leoa", "Sérvia", "Singapura", "Síria",
        "Somália", "Sri Lanka", "Suazilândia", "Sudão", "Sudão do Sul", "Suécia", "Suíça", "Suriname",
        "Tailândia", "Taiwan", "Tajiquistão", "Tanzânia", "Timor-Leste", "Togo", "Tonga", "Trindade e Tobago",
        "Tunísia", "Turcomenistão", "Turquia", "Tuvalu", "Ucrânia", "Uganda", "Uruguai", "Uzbequistão",
        "Vanuatu", "Vaticano", "Venezuela", "Vietnã", "Zâmbia", "Zimbábue"
    };

        public string Pais
        {
            get { return _pais; }
            set
            {
                if (!Paises.Contains(value))
                    throw new ArgumentException("País inválido. Selecione um dos 194 países reconhecidos.");
                _pais = value;
            }
        }
        private double _multa;
        public double Multa
        {
            get { return _multa; }
            set
            {
                if (value != 5)
                    throw new Exception("A multa é de 5 reais");
                _multa = value;
            }
        }
    }
}


