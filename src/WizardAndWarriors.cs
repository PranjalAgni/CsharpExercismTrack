using System;

abstract class Character
{
  private string characterType;
  protected Character(string characterType)
  {
    this.characterType = characterType;
  }

  public abstract int DamagePoints(Character target);

  public virtual bool Vulnerable()
  {
    return false;
  }

  public override string ToString()
  {
    return $"Character is a {this.characterType}";
  }
}

class Warrior : Character
{
  public Warrior() : base("Warrior")
  {
  }

  public override int DamagePoints(Character target)
  {
    return (target.Vulnerable()) ? 10 : 6;
  }
}

class Wizard : Character
{
  private bool isSpellPrepared;
  public Wizard() : base("Wizard")
  {
    this.isSpellPrepared = false;
  }

  public override int DamagePoints(Character target)
  {
    return (this.isSpellPrepared) ? 12 : 3;
  }

  public void PrepareSpell()
  {
    this.isSpellPrepared = true;
  }

  public override bool Vulnerable()
  {
    return !this.isSpellPrepared;
  }
}
