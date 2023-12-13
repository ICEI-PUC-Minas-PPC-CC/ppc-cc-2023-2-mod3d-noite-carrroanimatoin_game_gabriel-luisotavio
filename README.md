# Blender Animation && Unity Game

`PPC-CC: PUC Poços de Caldas - Ciência da Computação`
`Disciplina: Modelagem e Construção de Aplicações 3D`
`2023 - Semestre 2`

## Integrantes

- Gabriel Leite
- Luis Otavio Albergoni

## Professor

- Will Machado

## Arquivos Complementares
- O seguinte link https://sgapucminasbr-my.sharepoint.com/:f:/g/personal/1362862_sga_pucminas_br/EsJcEtOYaSRImQ7K8ralODwBhdOLnvBCpnDh7tvI1n2IUw?e=F3gYMV leva a um repositório no ONEDRIVE onde estão dois arquivos do Projeto: CarAnimation.blend que é o main, e o arquivo Mercedes-C63-AMG-V3-FIX.Blend que é o carro usado no projeto.
- Precisamos a esse repositório em nuvem pois os arquivos mesmo comprimidos estão com tamanho maior que 100MB, e o tamanho padrão aceito pelo GITHUB é 100MB. Tentamos usar o método do GIT LFS (git large files) que é usado para UPAR arquivos grandes para um repositório no GITHUB mas não obtivemos sucesso, recorrendo assim ao ONEDRIVE.

## Descrição
- Este repositório abriga dois projetos colaborativos de animação de carro feito no Blender e game feito na Unity, desenvolvidos por GABRIEL LEITE e LUIS OTAVIO. Diferentemente do processo tradicional de modelagem, optamos por importar um modelos previamente configurado como o RIGCAR para otimizar o tempo e aproveitar recursos existentes.
- O jogo feito na unity é um simples plataformer 3D feito primariamente com assets (os modelos 3D) nativos da unity, ele apresenta multiplas fases e scripts que dão a ele funcionalidade.

## Recursos Utilizados para CAR ANIMATION

- Modelagem 3D:
Importamos um modelo de carro pré-configurado como RIGCAR, permitindo-nos concentrar nas técnicas avançadas de modelagem, como extrusão e shading, para aprimorar detalhes e realismo.

- Cenário:
Importamos uma variedade de elementos, incluindo estrada, postes, construções e outro modelo de carro, para compor um ambiente diversificado e imersivo.

- Iluminação:
Implementamos uma iluminação eficaz na cena, incluindo postes com luzes planas e uma fonte de luz do tipo sol no centro do mapa para aprimorar a iluminação geral.

- Animação:
Adicionamos movimento dinâmico ao carro, utilizando keyframes para definir a trajetória ao longo da estrada. A rotação das rodas foi animada para proporcionar uma representação realista do movimento. Além disso, utilizamos keyframes para fazer a câmera acompanhar o carro até o final da animação, oferecendo uma perspectiva envolvente.

- Texturização:
Aplicamos texturas de alta qualidade para melhorar a estética do ambiente e proporcionar uma experiência visualmente agradável.

- Efeito de Névoa:
Implementamos um efeito de névoa utilizando um cubo que envolve toda a animação. A textura de volume scatter foi aplicada ao cubo, e a densidade foi ajustada para criar uma atmosfera envolvente.

## Recursos Utilizados para Unity Game

-Cenário 3D:
O jogo é um "plataformer" 3D com a perspectiva de terceira pessoa (a câmera é posicionada acima do protagonista).

-Modelos 3D:
Todos os elementos do jogo são figuras geometricas simples, porém distinguidas entre si.

-Game over:
No jogo, caso você caia das plataformas ou entre em contato com inimigos, o personagem morre e você tem que começar o nível de novo.

-Múltiplos Níveis:
Há mais de um nivel presente no jogo.

-Scripts:
Além da edição na engine em si, foi usado códigos feitos em C# para fazer a logica de colisão, game over, ir de um nível ao outro, waypoints(que faz a movimentação entre um ponto e outro, usado para movimentar os inimigos e plataformas).



# Código

<li><a href="src/README.md"> Código Fonte</a></li>

# Apresentação



https://github.com/ICEI-PUC-Minas-PPC-CC/ppc-cc-2023-2-mod3d-noite-carrroanimatoin_game_gabriel-luisotavio/assets/90779083/5ceeba52-af83-46aa-b600-b40688bdb648



https://github.com/ICEI-PUC-Minas-PPC-CC/ppc-cc-2023-2-mod3d-noite-carrroanimatoin_game_gabriel-luisotavio/assets/90779083/dadb514f-29b7-4d46-9550-57fea3ec31f6



