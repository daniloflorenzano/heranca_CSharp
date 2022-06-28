# heranca_CSharp

## Conceitos estudados

- **Herannça**: uma sub classe que extende as propriedades e métodos de uma super classe.
Ex: ``` class SavingsAccount : Account { } ```
- **Upcasting**: converção de uma sub classe para super classe. Ex: ``` Account acc = new SavingsAccount(); ```
- **Downcasting**: converção de uma super classe para sub classe. Ex: ``` SavingsAccount acc2 = acc as SavingsAccount; ```
- **override, virtual, base**: é possível reescrever reescrever em uma sub classe um método criado na super classe, e também acrescentar mais lógica. Ex:
``` c#
// metodo na super classe Account
public virtual void Withdraw(double amount)
{
  Balance -= amount + 5.0;
}

// metodo na sub classe SavingsAccount
public override void Withdraw(amount)
{
  base.Withdraw(amount); // repetindo a logica que está em Account
  Balance -= 2.0
}

```
- **sealed**: é possível impedir que sejam criadas extensões de uma classe, ou que um método já sobrescrito seja novamente sobrescrito. Ex:
``` c#
// classe selada
sealed class SavingAccounts : Account { }

// metodo selado
public sealed override void Withdraw(amount) { }
```
