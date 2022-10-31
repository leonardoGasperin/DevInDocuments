#DevInDocuments Projeto 1 Modulo 2

##### A empresa DEVinDocuments deseja automatizar todo o seu sistema de armazenamento de informações referentes aos seus documentos. Para isso, o sistema deverá conter diferentes tipos de documentos:

***

* Nota fiscal
	* A nota de fiscal deve conter:
		* Valor total.
		* Nome do produto vendido.
		* Tipo do imposto:
			* ICMS
			* IPI
			* IOF
			* Outro
		* Valor total do imposto.

* Licenças de funcionamento
	* A licença de funcionamento deve conter:
		* Endereço.
		* Área de atuação:
			* Industrial
			* Agropecuário
			* Metalúrgico
			* Tecnologia
			* Outro
* Contrato
	* O contrato deve conter:
		* Finalidade.
		* Testemunhas.
			* Nome de duas testemunhas
	* Data de expiração.

***

##### Todas as funcionários devem ser derivadas da classe Pessoa, que possui os seguintes atributos e métodos:

***

* Documento
	* Atributos
		* Código do documento <- deverá ser gerado automaticamente pelo sistema.
		* Data <- Data do sistema
		* Data da última alteração
			* Sempre que o documento sofrer uma alteração esta data deve ser alterada
		* Nome do estabelecimento
		* CNPJ
	* Métodos
		* Cadastrar documento
		* Listar documento
		* Alterar itens documento 
		* Alterar status do documento:
			* Ativo
			* Em tramitação
			* Suspenso

***

##### O DEVinDocuments também deverá apresentar os seguintes relatórios: 

***

* Listar todos os documentos.
* Listar todos os documentos conforme a opção que o usuário escolher:
	* Ativo
	* Em tramitação
	* Suspenso
* Total de documentos.
* Listar todos os documentos conforme a opção que o usuário escolher:
	* Nota fiscal
	* Licenças de funcionamento
	* Contrato
