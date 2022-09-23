<?php // Template Name: page-home ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>


	<section class="container">
		<h2 class="subtitulo"><?php the_title(); ?></h2>

		<?php if (have_rows('categoria_menu')) : while (have_rows('categoria_menu')) : the_row(); ?>
		<div class="menu-prato grid-8">
			<h2><?php the_sub_field('nome_categoria'); ?></h2>
			<ul>
				<?php if (have_rows('prato_menu')) : while (have_rows('prato_menu')) : the_row(); ?>
				<li>
					<span><sup>R$</sup><?php the_sub_field('preco_prato'); ?></span>
					<!-- 129 -->
					<div>
						<h3><?php the_sub_field('nome_prato'); ?></h3>
						<!-- Salmão Grelhado no Forno -->
						<?php the_sub_field('descricao_prato'); ?>
						<!-- Pequenas tiras de salmão feitas no alho e óleo -->
					</div>
				</li>
				<?php endwhile; else: endif; ?>
		</div>
		<?php endwhile; else: endif; ?>

	</section>

<?php endwhile; else: endif; ?>

<?php get_footer(); ?>
