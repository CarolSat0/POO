using AULA_03.models;

// "cc" seria o nome que atribuimos para a classe ContaCorrente
// "new ContaCorrente()" é um objeto
ContaCorrente cc = new ContaCorrente(50);
cc.numero = 1234;
cc.ExibirSaldo();

cc.sacar(10);

cc.ExibirSaldo();