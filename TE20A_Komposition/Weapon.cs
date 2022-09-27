using System;

public class Weapon
{
  public int minDamage = 5;
  public int maxDamage = 15;
  public string name = "Sword";

  private Random generator = new Random();

  public int Attack()
  {
    return generator.Next(minDamage, maxDamage);
  }
}
