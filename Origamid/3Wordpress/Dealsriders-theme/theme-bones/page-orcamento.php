<?php // Template Name: page-orcamento ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>
<div class="page-orcamento">
    <main>
        <div class="titulo-bg">
            <div class="titulo container">
                <p class="font-2-l-b cor-5">Cotações no seu email</p>
                <h1 class="font-1-xxl cor-0">Solicite um orçamento<span class="escuro3">.</span></h1>
            </div>
        </div>

        <form class="orcamento container" action="">
            <div class="orcamento-produto">
                <h2 class="font-1-xs cor-5">Motocicleta ou seguro?</h2>

                <input type="radio" name="tipo" value="motocicleta" id="motocicleta">
                <label for="motocicleta">Motocicleta</label>

                <input type="radio" name="tipo" value="seguro" id="seguro">
                <label for="seguro">Seguro</label>

                <div class="orcamento-conteudo" id="orcamento-motocicleta">
                    <h2 class="font-1-xs cor-5">Escolha a sua </h2>


                    <input type="radio" name="produto" value="golden" id="golden">
                    <label for="golden">Golden Fat <span>R$ 84.420 </span></label>
                    <div class="orcamento-detalhes">
                        <ul class="font-1-xs cor-8">
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/motor.svg" alt="Motor ">Milwaukee-Eight</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/carbono.svg" alt="Motor ">Cromado</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/velocidade.svg" alt="Motor ">242 km/h</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/rastreador.svg" alt="Motor ">Rastrador</li>
                        </ul>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Golden.jpg" alt="Motocicleta Preta com detalhes em dourado">
                    </div>

                    <input type="radio" name="produto" value="nightmare" id="nightmare">
                    <label for="nightmare">Nightmare <span>R$ 55.942</span></label>
                    <div class="orcamento-detalhes">
                        <ul class="font-1-xs cor-8">
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/motor.svg" alt="Motor ">Milwaukee-Eight</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/carbono.svg" alt="Motor ">Cromado</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/velocidade.svg" alt="Motor ">242 km/h</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/rastreador.svg" alt="Motor ">Rastrador</li>
                        </ul>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Black.jpg" alt="Motocicleta Preta">
                    </div>

                    <input type="radio" name="produto" value="old" id="old">
                    <label for="old">Old Chill <span>R$ 95.742</span></label>
                    <div class="orcamento-detalhes">
                        <ul class="font-1-xs cor-8">
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/motor.svg" alt="Motor ">Milwaukee-Eight</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/carbono.svg" alt="Motor ">Cromado</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/velocidade.svg" alt="Motor ">342 km/h</li>
                            <li><img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/laranjas/rastreador.svg" alt="Motor ">Rastrador</li>
                        </ul>
                        <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/index/lista/Old.jpg" alt="Motocicleta Laranja">
                    </div>

                </div>

                <div class="orcamento-conteudo" id="orcamento-seguro">
                    <h2 class="font-1-xs cor-5">Escolha o plano</h2>

                    <input type="radio" name="produto" value="silver" id="silver">
                    <label for="silver">Silver <span>R$240</span></label>

                    <input type="radio" name="produto" value="gold" id="gold">
                    <label for="gold">Gold <span>R$420</span></label>
                </div>

            </div>

            <div class="orcamento-dados form">
                <h2 class="font-1-xs cor-9 col-2">Dados pessoais</h2>
                <div>
                    <label for="nome">Nome</label>
                    <input type="text" id="nome" name="nome">
                </div>

                <div>
                    <label for="sobrenome">Sobrenome</label>
                    <input type="text" id="sobrenome" name="sobrenome">
                </div>

                <div class="col-2">
                    <label for="CPF">CPF</label>
                    <input type="text" id="CPF" name="CPF" placeholder="000.000.000-00">
                </div>

                <div class="col-2">
                    <label for="email">Email</label>
                    <input type="email" id="email" name="email">
                </div>



                <h2 class="font-1-xs cor-9 col-2">Entrega</h2>

                <div class="">
                    <label for="CEP">CEP</label>
                    <input type="text" id="CEP" name="CEP">
                </div>

                <div class="">
                    <label for="numero">Número</label>
                    <input type="text" id="numero" name="numero">
                </div>

                <div class="">
                    <label for="logadouro">Logadouro</label>
                    <input type="text" id="logadouro" name="logadouro">
                </div>

                <div class="">
                    <label for="bairro">Bairro</label>
                    <input type="text" id="bairro" name="bairro">
                </div>

                <div class="">
                    <label for="cidade">Cidade</label>
                    <input type="text" id="cidade" name="cidade">
                </div>

                <div class="">
                    <label for="estado">Estado</label>
                    <input type="text" id="estado" name="estado">
                </div>

                <div class="col-2 termos-form">
                    <input type="radio" id="termo" name="termo">
                    <label for="termos">Li e aceito os <a href="<?php echo get_home_url(); ?>/termos"> Termos e Condições</a>.</label>
                </div>

                <button class="btn-escuro col-2">Solicitar orçamento</button>
            </div>
        </form>
    </main>
</div>
<?php endwhile; else: endif ?>
<?php get_footer(); ?>
