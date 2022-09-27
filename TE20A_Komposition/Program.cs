Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.weapon = new Weapon();

int damage = f1.weapon.Attack();

f2.hp -= damage;

Console.WriteLine(f1.weapon.name);


Console.ReadLine();
