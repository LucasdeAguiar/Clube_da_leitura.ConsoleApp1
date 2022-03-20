using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura.ConsoleApp1
{
    internal class Menu
    {
        #region variáveis para verificação de existência
        public bool existeAmigo = false;
        public bool possuiRevista = false;
        public bool existeRevista = false;
        #endregion

        #region contadores
        public int contadorEmprestimos =0;
        public int contadorRevistas = 0;
        public int contadorAmigos = 0;
        public int contadorCaixas = 0;
        public int contadorReservas = 0;
        public int contadorCategorias = 0;
        #endregion

        #region arrays
        public Revista[] revistas = new Revista[100];
        public Amigo[] amigos = new Amigo[100];
        public Emprestimo[] filaEmprestimo = new Emprestimo[100];
        public Caixa[] caixas = new Caixa[100];
        public Reserva[] reservas = new Reserva[100];
        public Categoria[] categorias = new Categoria[100];
        Emprestimo emp1 = new Emprestimo();
        #endregion

        #region iniciar valores automaticamente
        

        public void iniciaValoresCaixas()
        {
            Caixa caixa1 = new Caixa();
            caixa1.cor = "Vermelho";
            caixa1.etiqueta = "abc123";
            caixa1.numero = "123";
            caixa1.revista_guardada = "Superman";
            caixa1.esta_guardando = true;
            caixas[contadorCaixas] = caixa1;    
            contadorCaixas++;

            Caixa caixa2 = new Caixa();
            caixa2.cor = "Azul";
            caixa2.etiqueta = "bcd321";
            caixa2.numero = "321";
            caixa2.revista_guardada = "Spider Man";
            caixa2.esta_guardando= true;
            caixas[contadorCaixas] = caixa2;
            contadorCaixas++;

            Caixa caixa3 = new Caixa();
            caixa3.cor = "Verde";
            caixa3.etiqueta = "xyz456";
            caixa3.numero = "456";
            caixas[contadorCaixas] = caixa3;
            contadorCaixas++;

            Caixa caixa4 = new Caixa();
            caixa4.cor = "Amarelo";
            caixa4.etiqueta = "zyx654";
            caixa4.numero = "654";
            caixas[contadorCaixas] = caixa4;
            contadorCaixas++;

            Caixa caixa5 = new Caixa();
            caixa5.cor = "Preto";
            caixa5.etiqueta = "qwe212";
            caixa5.numero = "212";
            caixas[contadorCaixas] = caixa5;
            contadorCaixas++;
        }

        public void iniciaValoresRevistas()
        {
            Revista rev1 = new Revista();
            rev1.registraValoresTeste();
            rev1.categoria.nome = "super heroi";
            rev1.categoria.dias_de_emprestimo = 2;

            revistas[0] = rev1;
            contadorRevistas++;

            Revista rev2 = new Revista();
            rev2.registraValoresTeste();
            rev2.nome = "Spider Man";
            rev2.tipo = "Marvel";
            rev2.ano_revista = 2004;
            rev2.categoria.nome = "super heroi";
            rev2.categoria.dias_de_emprestimo = 2;
            revistas[1] = rev2;
            contadorRevistas++;
        }

        public void iniciaValoresCategorias()
        {
            Categoria categoria1 = new Categoria();
            categoria1.nome = "super heroi";
            categoria1.dias_de_emprestimo = 5;
            categorias[contadorCategorias] = categoria1;
            contadorCategorias++;
            

            Categoria categoria2 =  new Categoria();
            categoria2.nome = "revista velha";
            categoria2.dias_de_emprestimo = 12;
            categorias[contadorCategorias] = categoria2;
            contadorCategorias++;
        }
        public void iniciaValoresAmigos()
        {
            Amigo amigo1 = new Amigo();
            amigo1.registraValoresTeste();
            amigo1.nome = "Carlos";
            amigos[0] = amigo1;
            contadorAmigos++;

            Amigo amigo2 = new Amigo();
            amigo2.registraValoresTeste();
            amigo2.nome = "Marquinhos";
            amigo2.nome_responsavel = "Jorge";
            amigos[1] = amigo2;
            contadorAmigos++;

            Amigo amigo3 = new Amigo();
            amigo3.registraValoresTeste();
            amigo3.nome = "Bruce";
            amigo3.nome_responsavel = "Thomas";
            amigos[2] = amigo3;
            contadorAmigos++;
        }

        public void iniciaValoresReservas()
        {
                Reserva reserva = new Reserva();
                reserva.amigo_reservado = amigos[0].nome;
                reserva.revista_Reservada = revistas[0].nome;

                reservas[0] = reserva;
                contadorReservas++;

            
        }

        #endregion


        public void iniciaMenu()
        {

            apresentaMenuGeral();

           
        }

       
        public void verificaAmigoPossuiRevista(string amigo)
        {
             possuiRevista = false;
            for (int i = 0; i < filaEmprestimo.Length; i++)
            {
                if (filaEmprestimo[i] != null)
                {
                    if (filaEmprestimo[i].amigo.nome == amigo)
                    {
                        possuiRevista = true;
                        break;
                    }



                }
            }
        }

        public Categoria escolhaCategoria()
        {
            Categoria categoria = new Categoria();
            bool achouCategoria = false;
            limpaTela();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("OPÇÕES DE CATEGORIAS:");
            for (int i = 0; i < contadorCategorias; i++)
            {
                
                categorias[i].mostrarCategoria();
                Console.WriteLine("\n");
            }
            resetaCor();
            Console.WriteLine("\n");
            Console.WriteLine("Digite o nome da categoria da revista");
             String nomeCategoria = Console.ReadLine();

            limpaTela();
            for (int i=0; i< contadorCategorias;i++)
            {
                if (categorias[i].nome == nomeCategoria)
                {
                    achouCategoria = true;
                }
            }
            if (achouCategoria)
            {
                categoria.nome = nomeCategoria;
            }

            Console.WriteLine("Digite a quantidade de dias de empréstimo");
            int dias_emprestimo = Convert.ToInt32(Console.ReadLine());

            categoria.dias_de_emprestimo = dias_emprestimo;

            return categoria;

        }
        public int escolhaPrazoCategoria()
        {
            Console.WriteLine("Digite os dias de empréstimo: ");
             int dias_emprestimo = Convert.ToInt32(Console.ReadLine());

            return dias_emprestimo;
        }

        public void verificaReserva()
        {
            Boolean amigoExiste = false;
            Boolean revistaExiste = false;

            Console.WriteLine("Digite o amigo que realizará a reserva:");
             string amigo = Console.ReadLine();

            Console.WriteLine("Digite o nome da revista que será reservada:");
            string revista = Console.ReadLine();

            for (int i=0; i<contadorAmigos;i++)
            {
                if (amigos[i].nome == amigo)
                {
                    amigoExiste = true;
                }
            }

            for (int i=0; i<contadorRevistas;i++)
            {
                if (revistas[i].nome == revista)
                {
                    revistaExiste = true;
                }
            }

            if (amigoExiste == true && revistaExiste == true)
            {
                    Reserva reserva = new Reserva();
                    reserva.add2dias();
                    reserva.amigo_reservado = amigo;
                    reserva.revista_Reservada = revista;
                    reservas[contadorReservas] = reserva;
                    contadorReservas++;
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dados Incorretos..");
                apertaEnter();
                resetaCor();
                
            }

        }
    
        public void emprestaRevista()
        {
            bool revistaEstaEmprestada = false;
             Emprestimo emp = new Emprestimo();
              existeAmigo = false;

            Console.WriteLine("Digite o nome do amigo que deseja emprestar:");
             string amigo = Console.ReadLine();

            for (int i = 0; i < contadorAmigos; i++)
            {
                if (amigos[i].nome == amigo)
                {
                    existeAmigo = true;
                    break;
                }
            }

            if(existeAmigo == true)
            {
                verificaAmigoPossuiRevista(amigo);

                if (possuiRevista)
                {
                    limpaTela();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(amigo + " já possui uma revista");

                    apertaEnter();
                    limpaTela();
                    resetaCor();

                }
                else
                {
                    emp.amigo.nome = amigo;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Amigo não existente..");
                resetaCor();
            }
            if (possuiRevista == false)
            {
                Console.WriteLine("Digite a revista que deseja emprestar:");
                string revista = Console.ReadLine();

                for (int i = 0; i < contadorRevistas; i++)
                {
                        if (revistas[i].nome == revista)
                        {
                           if (revistas[i].esta_emprestada == false)
                           {
                             revistas[i].esta_emprestada = true;
                             revistaEstaEmprestada = true;
                             emp.revista.nome = revista;
                             existeRevista = true;
                             break;

                            }

                        }
                    
                }

                if (!existeRevista)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A revista não existe..");
                    resetaCor();
                }



                if (revistaEstaEmprestada)
                {


                    emp.data_emprestimo = DateTime.Now;

                    do
                    {
                        Console.WriteLine("Digite a data de devolução da revista:");
                        emp.data_devolucao = Convert.ToDateTime(Console.ReadLine());

                        if (emp.data_devolucao < emp.data_emprestimo)
                        {
                            limpaTela();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Não é possível registrar a devolução no mesmo dia da data de empréstimo..");
                            Console.WriteLine("Por favor tente novamente");
                            resetaCor();
                            apertaEnter();
                        }
                    } while (emp.data_devolucao < emp.data_emprestimo);

                    limpaTela();
                    sucessoCadastro();
                    apertaEnter();

                    filaEmprestimo[contadorEmprestimos] = emp;
                    contadorEmprestimos++;
                }
                else
                {
                    limpaTela();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("A revista já está emprestada");
                    resetaCor();
                    apertaEnter();
                    
                }

                
            }
        }

        public void escolhaCaixa(string revista_guardada)
        {
            

            for (int i = 0; i < contadorCaixas; i++)
            {
                caixas[i].mostraCaixa();
                Console.WriteLine("\n");
                Console.WriteLine("----------------");
            }
            Console.WriteLine("Escolha uma das caixas para armazenar a revista:(Digite o número da caixa)");
             string caixa_escolhida = Console.ReadLine();

            for (int i = 0; i<contadorCaixas;i++)
            {
                if (caixas[i].numero == caixa_escolhida)
                {
                    if (caixas[i].esta_guardando == true)
                    {
                        
                        cadastroNegado();
                        break;
                        
                    }
                    else
                    {
                        caixas[i].revista_guardada = revista_guardada;
                        caixas[i].esta_guardando = true;
                        
                        sucessoCadastro();
                      
                        
                    }
                }
                
            }
       
            
        }
        
        #region menus 
        public void apresentaMenuGeral()
        {
            string opcao ="";

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("      CLUBE DA LEITURA");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Digite uma das opções:");
                Console.WriteLine("Opção 1: Ir para o menu de revistas");
                Console.WriteLine("Opção 2: Ir para o menu de caixas");
                Console.WriteLine("Opção 3: Ir para o menu de amigos");
                Console.WriteLine("Opção 4: Ir para o menu de empréstimos");
                Console.WriteLine("Opção 5: Ir para o menu de reservas");
                Console.WriteLine("Opção 6: Ir para o menu de categorias");
                Console.WriteLine("Digite s para sair do programa:");
                opcao = Console.ReadLine();

                if (opcao == "s")
                {
                    limpaTela();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fechando o programa..");
                    resetaCor();
                    break;

                }
                else if (opcao == "1")
                {
                    limpaTela();
                    menuRevista();
                    

                }
                else if (opcao == "2")
                {
                    limpaTela();
                    menuCaixa();

                }
                else if (opcao == "3")
                {
                    limpaTela();
                    menuAmigo();

                }
                else if (opcao == "4")
                {
                    limpaTela();
                    menuEmprestimo();
                }
                else if (opcao == "5")
                {
                    limpaTela();
                    menuReserva();
                }
                else if (opcao == "6")
                {
                    limpaTela();
                    menuCategoria();
                }
            } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "s");
        }
        public void menuRevista()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Revista");
            Console.WriteLine("Opção 2: Visualizar Revistas");
            Console.WriteLine("Opção 3: Voltar para o Menu");
          

            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                limpaTela();
                Revista rev = new Revista();
                rev.registraRevista();
                escolhaCaixa(rev.nome);
                Categoria categoria = new Categoria();
                categoria = escolhaCategoria();
                rev.categoria = categoria;
                contadorCategorias++;
               
              

                revistas[contadorRevistas] = rev;
                contadorRevistas++;

                limpaTela();
                menuRevista();


            }
            else if (opcao == "2")
            {
                limpaTela();
                for (int i = 0; i < contadorRevistas; i++)
                {
                    revistas[i].mostraRevista();
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------");
                }
                Console.ReadLine();
                limpaTela();
                menuRevista();

            }
            else if (opcao == "3")
            {
                limpaTela();
                iniciaMenu();

            }
        }
        public void menuCaixa()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Caixa");
            Console.WriteLine("Opção 2: Visualizar Caixas");
            Console.WriteLine("Opção 3: Voltar para o Menu");


            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                limpaTela();
                Caixa caixa = new Caixa();
                caixa.registraCaixa();
                caixas[contadorCaixas] = caixa;
                contadorCaixas++;
                limpaTela();
                menuCaixa();


            }
            else if (opcao == "2")
            {
                limpaTela();
                for (int i = 0; i < contadorCaixas; i++)
                {
                    caixas[i].mostraCaixa();
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------");
                }
                Console.ReadLine();
                limpaTela();
                menuCaixa();

            }
            else if (opcao == "3")
            {
                limpaTela();
                iniciaMenu();

            }


        }
        public void menuAmigo()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Amigo");
            Console.WriteLine("Opção 2: Visualizar Amigos");
            Console.WriteLine("Opção 3: Voltar para o Menu");


            opcao = Console.ReadLine();

            if (opcao == "1")
            {
               
                limpaTela();
                Amigo amigo = new Amigo();
                amigo.registraAmigo();
                amigos[contadorAmigos] = amigo;
                contadorAmigos++;
                limpaTela();
                menuAmigo();


            }
            else if (opcao == "2")
            {
                limpaTela();
                for (int i = 0; i < contadorAmigos; i++)
                {
                    amigos[i].mostraAmigo();
                    Console.WriteLine("\n");
                    Console.WriteLine("----------------");
                }

                Console.ReadLine();
                limpaTela();
                menuAmigo();

            }
            else if (opcao == "3")
            {
                limpaTela();
                iniciaMenu();

            }


        }
        public void menuEmprestimo()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Empréstimo");
            Console.WriteLine("Opção 2: Visualizar Empréstimos");
            Console.WriteLine("Opção 3: Voltar para o Menu");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                limpaTela();
                emprestaRevista();
                menuEmprestimo();
             }
            else if (opcao == "2")
            {
                limpaTela();
                Console.WriteLine("-------------");
                Console.WriteLine("Empréstimos");
                Console.WriteLine("-------------");
                for (int i = 0; i < contadorEmprestimos; i++)
                {
                    Console.WriteLine("Amigo: " + filaEmprestimo[i].amigo.nome);
                    Console.WriteLine("Revista: " + filaEmprestimo[i].revista.nome);
                    Console.WriteLine("Data do empréstimo: " + filaEmprestimo[i].data_emprestimo.ToShortDateString());
                    Console.WriteLine("Data de devolução: " + filaEmprestimo[i].data_devolucao.ToShortDateString());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("\n");
                }
                apertaEnter();
                menuEmprestimo();

            }
            else if (opcao == "3")
            {
                limpaTela();
                iniciaMenu();
            } 
        }
        public void menuReserva()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Reserva");
            Console.WriteLine("Opção 2: Visualizar Reservas");
            Console.WriteLine("Opção 3: Ir para o menu de registro de empréstimos:");
            Console.WriteLine("Opção 4: Voltar para o Menu");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                limpaTela();
                verificaReserva();
                limpaTela();
                menuReserva();

            }
            else if (opcao == "2")
            {
                limpaTela();
                for (int i = 0; i < contadorReservas; i++)
                {
                    reservas[i].mostraReserva();
                }
                apertaEnter();
                menuReserva();

            }
            else if (opcao == "3")
            {
                limpaTela();
                menuEmprestimo();
            }
            else if (opcao == "4")
            {
                limpaTela();
                iniciaMenu();
            }

        }
        public void menuCategoria()
        {
            string opcao;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      CLUBE DA LEITURA");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("Opção 1: Registrar Categoria");
            Console.WriteLine("Opção 2: Visualizar Categorias");
            Console.WriteLine("Opção 3: Voltar para o Menu");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                limpaTela();
                Categoria cat = new Categoria();
                cat.registraCategoria();
                categorias[contadorCategorias] = cat;
                contadorCategorias++;
                limpaTela();
                menuCategoria();
            }
            else if (opcao == "2")
            {
                limpaTela();
                for(int i = 0;i < contadorCategorias; i++)
                {
                    categorias[i].mostrarCategoria();
                }
                apertaEnter();
                limpaTela();
                menuCategoria();
            }
            else if (opcao == "3")
            {
                limpaTela();
                iniciaMenu();
            }
           
        }
        #endregion

        #region auxiliadores
        public void limpaTela()
        {
            Console.Clear();
        }
        public void resetaCor()
        {
            Console.ResetColor();
        }
        public void sucessoCadastro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro efetuado com sucesso!");
            resetaCor();
        }
        public void cadastroNegado()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não foi possível realizar o cadastro..");
            Console.ReadLine();
            resetaCor();
        }
        public void apertaEnter()
        {
            Console.WriteLine("Aperte ENTER para continuar..");
            Console.ReadLine();
            limpaTela();
        }

        #endregion

        #region erros
        //Problemas a se resolver:

        //As mensagens de erro não aparecem
        //O código permite que um amigo cadastre mais de um empréstimo
        //Implementar opção de editar e remover nos tópicos

        #endregion
        
        #region códigos antigos (verificar se pode excluir)
        /*
            public void verificaParaEmprestimo(string nameRevista, string nameAmigo) {

                Emprestimo emp = new Emprestimo();
                int daPraEmprestar=0;


                for (int i=0; i < contadorRevistas;i++)
                {


                    if (nameRevista == revistas[i].nome)
                    {
                        if (revistas[i].esta_emprestada == true)
                        {

                            Console.WriteLine("A revista já está emprestada..");
                            apertaEnter();
                            break;
                        }
                        else if(revistas[i].esta_emprestada == false)
                        {

                            emp.revista.nome = nameRevista;
                            emp.revista.tipo = revistas[i].tipo;
                            emp.revista.caixa_utilizada = revistas[i].caixa_utilizada;
                            emp.revista.ano_revista = revistas[i].ano_revista;
                            emp.revista.numero_edicao = revistas[i].numero_edicao;
                            emp.revista.esta_emprestada = true;
                            daPraEmprestar++;







                        }
                    }
                }

                for (int i = 0; i < contadorAmigos; i++)
                {
                    if (amigos[i] != null)
                    {


                        if (nameAmigo == amigos[i].nome)
                        {
                            if (amigos[i].pegou_uma_revista == true)
                            {
                                Console.WriteLine("O " + amigos[i].nome + " já pegou uma revista..");
                                apertaEnter();
                                break;
                            }
                            else if(amigos[i].pegou_uma_revista == false)
                            {

                                emp.amigo.nome = nameAmigo;
                                emp.amigo.nome_responsavel = amigos[i].nome_responsavel;
                                emp.amigo.telefone = amigos[i].telefone;
                                emp.amigo.endereco = amigos[i].endereco;
                                emp.amigo.pegou_uma_revista = true;
                                daPraEmprestar++;

                            }
                        }
                    }


                }

                if (daPraEmprestar == 2) {
                    filaEmprestimo[contadorEmprestimos] = emp;
                    contadorEmprestimos++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Empréstimo Cadastrado com sucesso!");
                    resetaCor();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Não foi possível realizar o cadastro!");
                    resetaCor();
                }
            }
        */

        #endregion

    }
}
