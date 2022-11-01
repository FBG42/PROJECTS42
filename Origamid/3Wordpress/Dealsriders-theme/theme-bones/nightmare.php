<?php // Template Name: page-nightmare ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>

    <main class="titulo-bg">
        <div>
            <div class="titulo container">
                <p class="font-2-xl cor-5">R$ 55.942</p>
                <h1 class="font-1-xxl cor-0">Nightmare<span class="escuro3">.</span></h1>
            </div>
        </div>

        <div class="motocicleta container">
            <div class="motocicleta-imgs">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Black.jpg" width="560" height="340" alt="Motocicleta Nightmare">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Golden.jpg" width="560" height="340" alt="Motocicleta Golden Hearts">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Old.jpg" width="560" height="340" alt="Motocicleta Old Chill">
            </div>

            <div class="motocicleta-conteudo">
                <p class="font-2-l cor-5">Uma devoradora de ruas com fome de potência. Motocicleta certa para renegados em busca da última palavra em potência e desempenho.</p>
                <div class="motocicleta-comprar">
                    <a href="../orcamento.html?tipo=motocicleta&produto=nightmare" class="btn-claro"> comprar agora</a>
                    <span class="font-1-xs cor-6"> <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/entrega.svg" alt=""> entrega em 5 dias</span>
                    <span class="font-1-xs cor-6"> <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/estoque.svg" alt="">42 em estoque</span>
                </div>
                <h2 class="font-1-s cor-2">Informações</h2>
                <ul class="motocicleta-informacoes">
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/motor.svg" alt="">
                        <h3 class="font-1-m cor-0">Motor Milwaukee-Eight</h3>
                        <p class="font-2-xs cor-5">Um motor poderoso que funciona suavemente, tendo 1.262 cilindradas, 159 cavalos de potência a 9.500 rpm.</p>
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/velocidade.svg" alt="">
                        <h3 class="font-1-m cor-0">242 km/h</h3>
                        <p class="font-2-xs cor-5">Com resposta imediata do acelerador e um ronco puro que alegra a alma, sendo a sua assinatura a adrenalina presente em cada arrancada.</p>
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/rastreador.svg" alt="">
                        <h3 class="font-1-m cor-0">Rastreador</h3>
                        <p class="font-2-xs cor-5">Rastreador e sistema anti-furto para garantir o seu sossego..</p>
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/carbono.svg" alt="">
                        <h3 class="font-1-m cor-0">Acabamento cromado</h3>
                        <p class="font-2-xs cor-5">O sutil toque de um acabamento cromado com alguns detalhes em dourado.</p>
                    </li>
                </ul>
            </div>
        </div>
    </main>

    <article class="motos-disponiveis container">
        <div>
            <h2 class="font-1-xxl ">Escolha a sua<span class="escuro3">.</span></h2>
        </div>

        <ul class="lista-motos">
            <li>
                <a href="./goldenheart.html">
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Golden.jpg" width="560" height="340" alt="Motocicleta preta Golden Fat">
                    <h3 class="font-1-xl">Golden Fat</h3>
                    <span class="font-2-m">R$ 84.420</span>
                </a>
            </li>


            <li>
                <a href="./oldchill.html">
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Old.jpg" width="560" height="340" alt="Motocicleta Laranja Old Chill">
                    <h3 class="font-1-xl">Old Chill</h3>
                    <span class="font-2-m">R$ 95.742</span>
                </a>
            </li>
        </ul>
    </article>

    <article class="seguro-bg">
        <div class="seguro container">
            <div class="seguro-img">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/seguros/Seguros2.jpg" width="600" width="800" alt="Pessoa andando de moto">
            </div>
            <div class="seguro-conteudo">
                <h2 class="font-1-xxl cor-0">Ande mais tranquilo com o nosso <span class="clara2">seguro.</span></h2>
                <p class="font-2-l cor-5">Inscreva-se em um dos planos do nosso seguro e aproveite diversos benefícios.</p>
                <a href="../seguros.html" class="btn-claro">Conheça mais</a>
            </div>
        </div>
    </article>

<?php endwhile; else: endif ?>

<?php get_footer(); ?>
  