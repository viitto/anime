using System;
using System.Collections.Generic;

class Program {
  public static void Main(){
    Console.WriteLine("Bem vindo aos AnimesIf Oficial!");
    Console.WriteLine("Seu Programa de Pirataria Oficial!");    
    Console.WriteLine("⠀⠀⠀⠀⣠⣶⡾⠏⠉⠙⠳⢦⡀⠀⠀⠀⢠⠞⠉⠙⠲⡀⠀");
    Console.WriteLine("⠀⠀⠀⣴⠿⠏⠀⠀⠀⠀⠀⠀⢳⡀⠀⡏⠀⠀⠀⠀⠀⢷");
    Console.WriteLine("⠀⠀⢠⣟⣋⡀⢀⣀⣀⡀⠀⣀⡀⣧⠀⢸⠀⠀⠀⠀⠀ ⡇");
    Console.WriteLine("⠀⠀⢸⣯⡭⠁⠸⣛⣟⠆⡴⣻⡲⣿⠀⣸⠀⠀ OK ⠀ ⡇");
    Console.WriteLine("⠀⠀⣟⣿⡭⠀⠀⠀⠀⠀⠀⢱⠀⠀⣿⠀⢹⠀⠀⠀⠀⠀⠀ ⡇");
    Console.WriteLine("⠀⠀⠙⢿⣯⠄⠀⠀⠀⠀⢀⡀⠀⠀⡿⠀⠀⡇⠀⠀⠀⠀⡼");
    Console.WriteLine("⠀⠀⠀⠀⠹⣶⠆⠀⠀⠀⠀⠀⠀⡴⠃⠀⠀⠘⠤⣄⣠⠞⠀");
    Console.WriteLine("⠀⠀⠀⠀⢸⣷⡦⢤⡤⢤⣞⣁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⠀⠀⢀⣤⣴⣿⣏⠁⠀⠀⠸⣏⢯⣷⣖⣦⡀⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⢀⣾⣽⣿⣿⣿⣿⠛⢲⣶⣾⢉⡷⣿⣿⠵⣿⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⣼⣿⠍⠉⣿⡭⠉⠙⢺⣇⣼⡏⠀⠀⠀⠀⣄⢸⠀⠀⠀⠀⠀⠀");
    Console.WriteLine("⣿⣿⣧⣀⣿ ……… ⣀⣰⣏⣘⣆⣀⠀⠀");
    int op = 0;
    do{
      try {
      op = Menu();
      switch(op){
        case 1 : GeneroInserir(); break;
        case 2 : GeneroListar(); break;
        case 3 : GeneroAtualizar(); break;
        case 4 : GeneroExcluir(); break;
        case 5 : AnimeInserir(); break;
        case 6 : AnimeListar(); break;
        case 7 : AnimeAtualizar(); break;
        case 8 : AnimeExcluir(); break;
      }
    }
    catch (Exception erro) {
      op = -1;
      Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
      Console.WriteLine("████▌▄▌▄▐▐▌█████");
      Console.WriteLine("████▌▄▌▄▐▐▌▀████");
      Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
    }
  } while(op != 0);
}

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("::::::::escolha uma oppcao::::::::");
    Console.WriteLine("01 - preciso adcionar um gênero");
    Console.WriteLine("02 - mostrar os gêneros já cadastrados");
    Console.WriteLine("03 - preciso editar gêneros");
    Console.WriteLine("04 - preciso apagar gêneros");
    Console.WriteLine("05 - preciso adicionar um anime");
    Console.WriteLine("06 - mostrar animes já cadastrados");
    Console.WriteLine("07 - preciso editar um anime");
    Console.WriteLine("08 - preciso apagar um anime");
    Console.WriteLine("00 - sayonara");
    Console.WriteLine("::::::::::::::::::::::::::::::::::");
    Console.Write("Opcao:  ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  
  public static void GeneroInserir() {
    Console.WriteLine("::::coloca um gênero::::");
    Console.Write("diz o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroInserir(obj);
    Console.WriteLine("::::::missão cumprida::::::");
}
  public static void GeneroListar() {
    Console.WriteLine(":::: mostrar os gêneros cadastrados::::");
    foreach(Genero obj in Sistema.GeneroListar())
      Console.WriteLine(obj);
    Console.WriteLine("::::::::::::::::::::::::::::::::::");
    
  }

  public static void GeneroAtualizar() {
    Console.WriteLine("::::Atualizar um gênero::::");
    Console.Write("diz o id o gênero aí pra editar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o novo titulo: ");
    string titulo = Console.ReadLine();
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroAtualizar(obj);
    Console.WriteLine("::::::missão cumprida::::::");
  }

  public static void GeneroExcluir() {
    Console.WriteLine(":::: apagar um gênero::::");
    Console.Write("idiz o id do gênero pra excluir: ");
    int id = int.Parse(Console.ReadLine());
    string titulo = "";
    Genero obj = new Genero(id, titulo);
    Sistema.GeneroExcluir(obj);
    Console.WriteLine("::::::missão cumprida::::::");
  }
  public static void AnimeInserir() {
    Console.WriteLine("::::adiciona um novo anime::::");
    Console.Write("diz o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();

    GeneroListar();
    Console.Write("passa o id do Genero:");
    int idGenero = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id, titulo, idGenero);
    Sistema.AnimeInserir(obj);
    Console.WriteLine(":::::::missão cumprida:::::::");
}
  public static void AnimeListar() {
    Console.WriteLine("::::mostrar os animes adicionados::::");
    foreach(Anime obj in Sistema.AnimeListar())
      Console.WriteLine(obj);
    Console.WriteLine("::::::::::::::::::::::::::::::::::");
    
  }

  public static void AnimeAtualizar() {
    Console.WriteLine("::::editar um anime::::");
    Console.Write("diz o id do anime pra editar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("diz o titulo: ");
    string titulo = Console.ReadLine();
    GeneroListar();
    Console.Write("diz o id do Genero: ");
    int idGenero = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id, titulo, idGenero);   
    Sistema.AnimeAtualizar(obj);
    Console.WriteLine("::::::::missão cumprida::::::::");
  }

  public static void AnimeExcluir() {
    Console.WriteLine("::::apagar um anime::::");
    Console.Write("passa o id do anime pra ser apagado: ");
    int id = int.Parse(Console.ReadLine());
    Anime obj = new Anime(id);
    Sistema.AnimeExcluir(obj);
    Console.WriteLine("::::missão cumprida::::");
  }  
}