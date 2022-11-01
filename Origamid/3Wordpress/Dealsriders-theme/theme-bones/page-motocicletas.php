<?php // Template Name: page-motocicletas ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>
    <main>
        <div class="titulo-bg">
            <div class="titulo container">
                <p class="font-2-l-b cor-5">Escolha a que mais combina com você</p>
                <h1 class="font-1-xxl cor-0">nossas motocicletas<span class="escuro3">.</span></h1>
            </div>
        </div>


        <div class="motocicletas container">
            <div class="motocicletas-img">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Black.jpg" width="560" height="340" alt="Motocicleta Nightmare">
                <span class="font-2-m cor-0">R$ 55.942</span>
            </div>

            <div class="motocicletas-conteudo">
                <h2 class="font-1-xl">Nightmare</h2>
                <p class="font-2-m cor-8">
                    Uma devoradora de ruas com fome de potência. Motocicleta certa para renegados em busca da última palavra em potência e desempenho.
                </p>

                <ul class="font-1-m cor-8">
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/motor.svg" alt="" width="24" height="24">
                        Motor Milwaukee-Eight™ 114
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/carbono.svg" alt="" width="24" height="24">
                        Acabamento cromado
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/velocidade.svg" alt="" width="24" height="24">
                        242 km/h
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/rastreador.svg" alt="" width="24" height="24">
                        Rastreador
                    </li>
                </ul>
                <a href="<?php echo get_home_url(); ?>/nightmare" class="btn-escuro seta">mais sobre</a>
            </div>
        </div>


        <div class="motocicletas-bg">
            <div class="motocicletas container">
                <div class="motocicletas-img">
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Golden.jpg" width="560" height="340" alt="Motocicleta Golden Fat">
                    <span class="font-2-m cor-0">R$ 84.420</span>
                </div>

                <div class="motocicletas-conteudo">
                    <h2 class="font-1-xl cor-0 detalhe">Golden Fat</h2>
                    <p class="font-2-m cor-5">
                        Os que desejam um toque a mais de luxuría, não percam por esperar.
                    </p>

                    <ul class="font-1-m cor-5">
                        <li>
                            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/motor.svg" alt="" width="24" height="24">
                            Motor Milwaukee-Eight™ 114
                        </li>
                        <li>
                            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/carbono.svg" alt="" width="24" height="24">
                            Acabamento cromado
                        </li>
                        <li>
                            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/velocidade.svg" alt="" width="24" height="24">
                            242 km/h
                        </li>
                        <li>
                            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/rastreador.svg" alt="" width="24" height="24">
                            Rastreador
                        </li>
                    </ul>
                    <a href="<?php echo get_home_url(); ?>/golden-fat" class="btn-claro seta">mais sobre</a>
                </div>
            </div>
        </div>


        <div class="motocicletas container">
            <div class="motocicletas-img">
                <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/bikes/Old.jpg" width="560" height="340" alt="Motocicleta Nightmare">
                <span class="font-2-m cor-0">R$ 95.742</span>
            </div>

            <div class="motocicletas-conteudo">
                <h2 class="font-1-xl">Old Chill</h2>
                <p class="font-2-m cor-8">
                    Para os que desejam ir contra o fluxo e não se abalar por pouco, com estilo esportivo e intenso.
                </p>

                <ul class="font-1-m cor-8">
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/motor.svg" alt="" width="24" height="24">
                        Motor Milwaukee-Eight™ 114
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/carbono.svg" alt="" width="24" height="24">
                        Acabamento cromado
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/velocidade.svg" alt="" width="24" height="24">
                        342 km/h
                    </li>
                    <li>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/rastreador.svg" alt="" width="24" height="24">
                        Rastreador
                    </li>
                </ul>
                <a href="<?php echo get_home_url(); ?>/old-chill" class="btn-escuro seta"> mais sobre</a>
            </div>
        </div>


    </main>

<?php endwhile; else: endif ?>
<?php get_footer(); ?>