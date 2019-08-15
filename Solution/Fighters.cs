public class Fighters {
  public static string declareWinner(
	  Fighter fighter1, 
	  Fighter fighter2, 
	  string firstAttacker) {


    // Your code goes here. Have fun!

	return "Someone";
  }
}

public class Fighter {
  public string Name;
  public int Health, DamagePerAttack;
  public Fighter(string name, int health, int damagePerAttack) {
    this.Name = name;
    this.Health = health;
    this.DamagePerAttack = damagePerAttack;
  }
}