<?php // Template Name: page-home ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>

  <main class="introducao-bg">
    <div class="introducao container">
      <div class="introducao-conteudo">
        <h1 class="font-1-xxl cor-0 fadeInDown" data-anime="300">Motocicletas customizadas<span class="escuro3">.</span></h1>
        <p class="font-2-l cor-5 fadeInDown" data-anime="600">Bicicletas elétricas de alta precisão e qualidade, feitas sob medida para você. <br> Explore o mundo na sua velocidade com a Bikcraft.</p>
        <a class="btn-escuro fadeInDown" href="<?php echo get_home_url(); ?>/motocicletas" data-anime="900">Escolha a sua</a>
      </div>
      <picture class="fadeInDown" data-anime="1200">
        <source media="(max-width: 800px)" srcset="<?php echo get_template_directory_uri(); ?>/library/imgs/index/GoldenHearts.jpg">
        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/img-intro.jpg" alt="Motocicleta Harley Davidson Preta" width="640" height="800">
      </picture>
    </div>
  </main>

  <article class="motos-disponiveis">
    <div class="container">
      <h2 class="font-1-xxl ">disponíveis no momento<span class="escuro3">.</span></h2>
    </div>

    <ul class="lista-motos">
      <li>
        <a href="<?php echo get_home_url(); ?>/nightmare">
          <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/nightmare-index.jpg" width="460" height="520" alt="Motocicleta Preta Nightmare">
          <h3 class="font-1-xl">Nightmare</h3>
          <span class="font-2-m">R$ 55.942</span>
        </a>
      </li>

      <li>
        <a href="<?php echo get_home_url(); ?>/golden-fat">
          <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/golden-index.jpg" width="460" height="520" alt="Motocicleta Preta Golden Heart's">
          <h3 class="font-1-xl">Golden Fat</h3>
          <span class="font-2-m">R$ 84.420</span>
        </a>
      </li>

      <li>
        <a href="<?php echo get_home_url(); ?>/old-chill">
          <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/old-index.jpg" width="460" height="520" alt="Motocicleta Laranja Old Chill">
          <h3 class="font-1-xl">Old Chill</h3>
          <span class="font-2-m">R$ 95.742</span>
        </a>
      </li>
    </ul>
  </article>

  <article class="tecnologia-bg">
    <div class="container tecnologia">
      <div class="tecnologia-info">
        <div class="tecnologia-avancada">
          <span class="font-2-l-b cor-5 ">tecnologia avançada</span>
          <h2 class="font-1-xxl cor-0">você escolhe os detalhes<span class="clara2">.</span></h2>
          <p class="font-2-l cor-5">Cada motocicleta será única e possui a sua identidade que você pode escolher. Os detalhes você deseja e nós realizamos, dando assim uma assinatura pessoal para sua moto. Assim descrevendo a cor e detalhes que deseja nos orçamentos.</p>
          <a href="<?php echo get_home_url(); ?>/motocicletas" class="link">ESCOLHA UM MODELO</a>
        </div>
        <div class="tecnologia-flex">
          <div class="tecnologia-vantagem">
            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/motor.svg" alt="" width="32" height="32">
            <h3 class="font-1-l cor-0">Motor</h3>
            <p class=" font-2-s cor-5">Nossas motos tem motores Milwaukee-Eight é a nona geração de motores "big twin" desenvolvidos pela querida Harley Davidson.</p>
          </div>
          <div class="tecnologia-vantagem">
            <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/rastreador.svg" alt="" width="32" height="32">
            <h3 class="font-1-l cor-0">Rastreador</h3>
            <p class=" font-2-s cor-5">Sabemos o quão preciosa é a seu bebê, por isso adicionamos rastreadores e sistemas anti-furto para garantir o seu sossego.</p>
          </div>
        </div>
      </div>
      <div class="tecnologia-img">
        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/diferencial.jpg" alt="">
      </div>

    </div>
  </article>


  <section class="parceiros" aria-label="parceiros">
    <h2 class="font-1-xxl container">nossos parceiros<span class="clara1">.</span></h2>

    <ul>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/caravan.svg" alt="caravan"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/dogs.svg" alt="dogs"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/flexblog.svg" alt="flexblog"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/handel.svg" alt="handel"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/lescone.svg" alt="LeScone"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/ranek.svg" alt="ranek"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/surfbot.svg" alt="surfbot"></li>
      <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/parceiros/wildbeast.svg" alt="wildbeast"></li>
    </ul>

  </section>

  <section class="depoimento">
    <div>
      <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/seguros/Seguros1.jpg" width="780" height="680" alt="Pessoa andando de moto (old chill)" width="780" height="680">
    </div>
    <div class="depoimento-conteudo">
      <blockquote class="font-1-xl escuro0">
        <p>O tempero de adrenalina, liberdade que meus dias precisavam era a old chill.</p>
      </blockquote>
      <span class="font-1-m-b escuro1">Ytalo Martins</span>
    </div>
  </section>

  <article class="seguros-bg">
    <div class="seguros container">
      <h2 class="font-1-xxl cor-0">seguros<span class="clara2">.</span></h2>

      <div class="seguros-item">
        <h3 class="font-1-xl cor-6">SILVER</h3>
        <span class="font-1-xl cor-0">R$240 <span class="font-1-xs cor-6">mensal</span></span>

        <ul class="font-2-m cor-0">
          <li>Revisões a semestrais</li>
          <li>Assistência técnica</li>
          <li>Suporte 08h às 18h</li>
          <li>Cobertura estadual</li>
        </ul>
        <a href="<?php echo get_home_url(); ?>/orcamento" class="btn-escuro silver">Inscreva-se</a>
      </div>

      <div class="seguros-item">
        <h3 class="font-1-xl clara3">GOLD</h3>
        <span class="font-1-xl cor-0">R$420 <span class="font-1-xs cor-6">mensal</span></span>

        <ul class="font-2-m cor-0">
          <li>Revisões a cada 2 meses</li>
          <li>Assistência especial</li>
          <li>Suporte 24h</li>
          <li>Cobertura nacional</li>
          <li>Desconto em parceiros</li>
          <li>Acesso ao Clube Riders on the Storm</li>
        </ul>
        <a href="<?php echo get_home_url(); ?>/orcamento" class="btn-claro">Inscreva-se</a>
      </div>
    </div>
  </article>

<?php endwhile; else: endif ?>

<?php get_footer(); ?>
  