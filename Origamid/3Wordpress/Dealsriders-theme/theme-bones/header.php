<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">


  <title><?php wp_title('-'); ?> <?php the_field('title_seo') ?></title>
  <meta property="og:title" content="<?php wp_title('-'); ?> <?php the_field('title_seo') ?>">
  <meta name="og:description" content="<?php wp_title('-'); ?> <?php the_field('description_seo') ?>">
  <meta name="og:url" content="<?php bloginfo('url'); ?>">

  <link rel="icon" href="<?php echo get_template_directory_uri(); ?>/favicon.svg" type="image/svg+xml">
  <!-- <link href="<?php echo get_template_directory(); ?>/library/css/style.css" rel="preload" as="style">
  <link href="<?php echo get_template_directory(); ?>/library/css/style.css" rel="stylesheet"> -->


  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Merriweather:ital,wght@0,400;0,700;1,400;1,700&family=Roboto+Slab:wght@400;500&family=Sancreek&display=swap" rel="stylesheet">

  <script> document.documentElement.classList.add('js')</script>

  <!-- Init Wordpress Header -->
  <?php wp_head(); ?>
  <!-- End Wordpress Header -->
</head>

<body>
  <header class="header-bg">
    <div class="header container">
      <div>
        <a href="<?php echo get_home_url(); ?>">
          <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/logos/Logo.svg" alt="Deals Riders" width="355" height="111">
        </a>
      </div>
      <nav aria-label="primaria">
        <ul class="header-menu font-1-m-b cor-1">
          <li><a href="<?php echo get_home_url(); ?>/motocicletas">Motocicletas</a></li>
          <li><a href="<?php echo get_home_url(); ?>/seguros">Seguros</a></li>
          <li><a href="<?php echo get_home_url(); ?>/contato">Contato</a></li>
        </ul>
      </nav>
    </div>
  </header>