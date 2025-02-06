using System.Numerics;
using System.Security.Cryptography;
using static System.Console;
using static System.Convert;
public class Program
{
    
    static void Main(string[] args)
    {
        List<Contatos> listContatos = new List<Contatos>();
        do
        {
            Clear();
            WriteLine("+++++ CADASTRO DE CONTATOS +++++\n");
            WriteLine("[1] Cadastrar");
            WriteLine("[2] Listar Contatos ");
            WriteLine("[3] Sair ");
            int op = ToInt32(ReadLine());

            
            if (op == 1)
            {
                try
                {
                    Write("Digite o nome: ");
                    string nome = ReadLine();
                    Write("Digite o phone: ");
                    string phone = ReadLine();
                    Contatos contato = new Contatos(nome, phone);
                    Write("Digite o email: ");
                    contato._email = ReadLine();
                    Write("Digite o avatar: ");
                    contato._avatar = ReadLine();
                    WriteLine("\nCadastrado com sucesso!");
                    contato.SetId(listContatos.Count + 1);

                    listContatos.Add(contato);
                    ReadKey();

                }catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
            else if (op == 2)
            {
                Clear();
                foreach (var agenda in listContatos)
                {
                    WriteLine($"\nID: {agenda.GetId}");
                    WriteLine($"Nome: {agenda._nome}");
                    WriteLine($"Telefone: {agenda._phone}");
                    WriteLine($"E-mail: {agenda._email}");
                    WriteLine($"Avatar: {agenda._avatar}\n");
                    WriteLine("----------------------------------");
                }
                ReadKey();
            }else if (op == 3)

            {
                break;
            }


        }
        while (true);
    }
}
