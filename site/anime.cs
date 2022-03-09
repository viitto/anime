using System;

class Anime {
  private int id;
  private string titulo;
  private int idGenero;

  public Anime(int id) {
    this.id = id;
  } 
  
  public Anime(int id, string titulo, int idGenero) {
    this.id = id;
    this.titulo = titulo;
    this.idGenero = idGenero;
  }
  public void SetId(int id) {
    this.id = id;  
  }
  public void SetTitulo(string titulo){
    this.titulo = titulo;
  }

  public void SetGenero(int idGenero) {
    this.idGenero = idGenero;  
  }
  
  public int GetId(){
    return id;
  }
  public String GetTitulo() {
    return titulo;
  }
  
  public int GetIdGenero(){
    return idGenero;
  }

  public override string ToString() {
    return $"{id} - {titulo} - {idGenero}";
  }
}