<article class="seguros-bg">
    <div class="seguros container">
      <h2 class="font-1-xxl cor-0">seguros<span class="clara2">.</span></h2>
      
      <div class="seguros-item">
        <h3 class="font-1-xl cor-6"><?=the_field('titulo_seguro_1', 18);?></h3>
        <span class="font-1-xl cor-0">R$<?=the_field('preco_seguro_1', 18)?> <span class="font-1-xs cor-6">mensal</span></span>

        <?php if( have_rows('vantagens_seguro_1', 18) ): ?>
         <ul class="font-2-m cor-0">
            <?php while ( have_rows('vantagens_seguro_1', 18) ) : the_row(); ?>
               <li><?=the_sub_field('vantagem_1', 18);?></li>
               <li><?=the_sub_field('vantagem_2', 18);?></li>
               <li><?=the_sub_field('vantagem_3', 18);?></li>
               <li><?=the_sub_field('vantagem_4', 18);?></li>
            <?php endwhile; ?>
         </ul>
        <?php endif; ?>
        <a href="<?php echo get_home_url(); ?>/orcamento" class="btn-escuro silver">Inscreva-se</a>
      </div>

      <div class="seguros-item">
        <h3 class="font-1-xl clara3"><?=the_field('titulo_seguro_2', 18);?></h3>
        <span class="font-1-xl cor-0">R$<?=the_field('preco_seguro_2', 18);?><span class="font-1-xs cor-6">mensal</span></span>

        <?php if( have_rows('vantagens_seguro_1', 18) ): ?>
            <ul class="font-2-m cor-0">
               <?php while ( have_rows('vantagens_seguro_2', 18) ) : the_row(); ?>
                  <li><?=the_sub_field('vantagem_1', 18);?></li>
                  <li><?=the_sub_field('vantagem_2', 18);?></li>
                  <li><?=the_sub_field('vantagem_3', 18);?></li>
                  <li><?=the_sub_field('vantagem_4', 18);?></li>
                  <li><?=the_sub_field('vantagem_5', 18);?></li>
                  <li><?=the_sub_field('vantagem_6', 18);?></li>
               <?php endwhile; ?>
            </ul>
        <?php endif; ?>

        <a href="<?php echo get_home_url(); ?>/orcamento" class="btn-claro">Inscreva-se</a>
      </div>
    </div>
  </article>