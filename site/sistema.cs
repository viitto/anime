using System;
using System.Collections.Generic;

class Sistema {
  private static Genero[] generos = new Genero[10];
  private static int nGenero;
  private static List<Anime> animes = new List<Anime>();

  public static void GeneroInserir(Genero obj) {
    if (nGenero == generos.Length)
      Array.Resize(ref generos, 2 * generos.Length);
      generos[nGenero] = obj;
      nGenero++;
  }
  public static Genero[] GeneroListar() {
    Genero[] aux = new Genero[nGenero];
    Array.Copy(generos, aux, nGenero);
    return aux;
  }

  public static Genero GeneroListar(int id) {
    foreach(Genero obj in generos)
      if (obj != null && obj.GetId() == id) return obj;
    return null;
  }
  public static void GeneroAtualizar(Genero obj){
    Genero aux = GeneroListar(obj.GetId());
      if (aux != null)
        aux.SetNome(obj.GetNome());
  }
  public static void GeneroExcluir(Genero obj) {
    int aux = GeneroIndice(obj.GetId());
    if (aux != -1) {
      for (int i = aux; i < nGenero - 1; i++)
        generos[i] = generos[i + 1];
      nGenero--;
    }
  }
  private static int GeneroIndice(int id){
    for(int i = 0; i < nGenero; i++){
      Genero obj = generos[i];
    if (obj.GetId() == id) return i;
    }
    return -1;
  }
  
  public static void AnimeInserir(Anime obj) {
      animes.Add(obj);
  }
  public static List<Anime> AnimeListar() {
    return animes;
  }

  public static Anime AnimeListar(int id) {
    foreach(Anime obj in animes)
      if (obj.GetId() == id) return obj;
    return null;
  }
  public static void AnimeAtualizar(Anime obj){
    Anime aux = AnimeListar(obj.GetId());
    if (aux != null){
      aux.SetTitulo(obj.GetTitulo());
      aux.SetGenero(obj.GetIdGenero());
    }
  }
  
  public static void AnimeExcluir(Anime obj) {
    Anime aux = AnimeListar(obj.GetId());

    if (aux != null) animes.Remove(aux);
    
  }
}