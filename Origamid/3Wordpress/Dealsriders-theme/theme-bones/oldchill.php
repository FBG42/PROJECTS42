<?php // Template Name: page-oldchill ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>

    <main class="titulo-bg">
        <div>
            <div class="titulo container">
                <p class="font-2-xl cor-5">R$ 95.742</p>
                <h1 class="font-1-xxl cor-0">Old Chill<span class="escuro3">.</span></h1>
            </div>
        </div>

        <div class="motocicleta container">
            <div class="motocicleta-imgs">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Old.jpg" width="560" height="340" alt="Motocicleta Old Chill" class="segundaria">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Golden.jpg" width="560" height="340" alt="Motocicleta Golden Hearts">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Black.jpg" width="560" height="340" alt="Motocicleta Nightmare" class="segundaria">
            </div>

            <div class="motocicleta-conteudo">
                <p class="font-2-l cor-5">A motocicleta certa para os mavericks que desejam sair da linha, estilo esportivo massivo e intenso.</p>
                <div class="motocicleta-comprar">
                    <a href="<?php echo get_home_url(); ?>/orcamento.html?tipo=motocicleta&produto=old" class="btn-claro"> comprar agora</a>
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
                        <h3 class="font-1-m cor-0">342 km/h</h3>
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
                <a href="<?php echo get_home_url(); ?>/nightmare">
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Black.jpg" width="560" height="340" alt="Motocicleta preta Nightmare">
                    <h3 class="font-1-xl">Nightmare</h3>
                    <span class="font-2-m">R$ 55.942</span>
                </a>
            </li>


            <li>
                <a href="<?php echo get_home_url(); ?>/goldenheart">
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Golden.jpg" width="560" height="340" alt="Motocicleta Preta Golde Heart's">
                    <h3 class="font-1-xl">Golden Fat</h3>
                    <span class="font-2-m">R$ 84.420</span>
                </a>
            </li>
        </ul>
    </article>

    <article class="seguro-bg">
        <div class="seguro container">
            <div class="seguro-img">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/seguros/Seguros2.jpg" width="600" height="800" alt="Pessoa andando de moto">
            </div>
            <div class="seguro-conteudo">
                <h2 class="font-1-xxl cor-0">Ande mais tranquilo com o nosso <span class="clara2">seguro.</span></h2>
                <p class="font-2-l cor-5">Inscreva-se em um dos planos do nosso seguro e aproveite diversos benefícios.</p>
                <a href="<?php echo get_home_url(); ?>/seguros" class="btn-claro">Conheça mais</a>
            </div>
        </div>
    </article>

<?php endwhile; else: endif ?>

<?php get_footer(); ?>
  