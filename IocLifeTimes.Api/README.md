# IocLifetimes.Api

<img src="https://github.com/flavio-santos-ti/dev-patterns-lab/blob/main/assets/banner-dev-patterns-lab.png" alt="Banner Dev Patterns Lab" style="width:100%;" />

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
    "_singleton1": "014ef53c-537d-41c0-8c41-f19d85abb9be",
    "_singleton2": "014ef53c-537d-41c0-8c41-f19d85abb9be"
  },
  "scoped": {
    "_scoped1": "0ab4f393-a7f8-454e-831a-132d97d76bc6",
    "_scoped2": "0ab4f393-a7f8-454e-831a-132d97d76bc6"
  },
  "transient": {
    "_transient1": "78c4e12a-c10b-4873-a85d-e9b3ee626fbe",
    "_transient2": "1b575a0c-2a35-4f6e-906f-643587ab8cb7"
  }
}
```
