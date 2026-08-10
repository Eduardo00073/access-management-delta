# Politica de Seguranca

Este repositorio (access-management-delta) e um sistema didatico de controle de acesso em C# Windows Forms com SQL Server, mantido por Eduardo Junior.

## Reportando um problema

Se encontrar alguma vulnerabilidade (por exemplo, relacionada a autenticacao, permissao de usuarios ou acesso ao banco de dados), abra uma issue explicando o contexto.

## Boas praticas recomendadas

- Nao reutilize as credenciais de exemplo em ambientes reais.
- Utilize connection strings fora do controle de versao (variaveis de ambiente ou arquivos de configuracao ignorados pelo Git).
- Aplique o principio do menor privilegio para usuarios do sistema.
