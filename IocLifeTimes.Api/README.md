# IocLifetimes.Api

[![.NET](https://img.shields.io/badge/.NET-7.0-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Build](https://img.shields.io/badge/build-passing-brightgreen)](#)

> 🎓 Projeto educacional para demonstrar o comportamento dos **ciclos de vida de dependência (IoC Lifetimes)** no container de injeção de dependência do ASP.NET Core.

---

## 🎯 Objetivo

Este projeto foi criado com o propósito de mostrar, de forma simples, prática e didática, como o **IoC Container** do ASP.NET Core gerencia o ciclo de vida das dependências por meio dos três lifetimes disponíveis:

- `Singleton`
- `Scoped`
- `Transient`

---

## 🧠 Conceitos demonstrados

| Lifetime    | Instância por   | Mantém o mesmo valor em | Muda em                         |
| :---------- | :-------------- | :---------------------- | :------------------------------ |
| `Singleton` | Aplicação       | Todas as requisições    | Apenas ao reiniciar a aplicação |
| `Scoped`    | Requisição HTTP | Uma mesma requisição    | Entre diferentes requisições    |
| `Transient` | Resolução       | Nunca                   | Sempre                          |

---

## 🧪 Teste visual

O endpoint `/guid` retorna duas instâncias injetadas de cada tipo para demonstrar o comportamento real:

```json
{
  "singleton": {
    "_singleton1": "SingletonService #1",
    "_singleton2": "SingletonService #1"
  },
  "scoped": {
    "_scoped1": "ScopedService #2",
    "_scoped2": "ScopedService #2"
  },
  "transient": {
    "_transient1": "TransientService #3",
    "_transient2": "TransientService #4"
  }
}
```
