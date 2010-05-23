ECG - SISTEMA PARA DETECCAO DE PATOLOGIAS EM ELETROCARDIOGRAMAS
Universidade Candido Mendes Campos - RJ
Ciencia da Computacao
Alaor Barroso de Carvalho Neto

*****************************************************************************************

Convencoes:

1) Codigos para Patologias do complexo QRS

	Patologia								Codigo				Padrao
	------------------------------------	----------------	-------------
	Normal									NORMAL				0 - 0 - 0 - 1
	Extra-Sistole Ventricular				ESV					0 - 0 - 1 - 0

2) Codigos para Patologias da onda T

	Patologia								Codigo				Padrao
	------------------------------------	----------------	-------------
	Normal									NORMAL				0 - 0 - 0 - 1
	Inexistente								INEXISTENTE			0 - 0 - 1 - 0
	Hipercalemia							HIPERCALEMIA		0 - 1 - 0 - 0
	Isquemia								ISQUEMIA			1 - 0 - 0 - 0

	Frequencia Cardiaca: Dividir por 8