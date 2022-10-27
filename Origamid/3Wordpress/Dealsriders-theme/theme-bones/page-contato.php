<?php // Template Name: page-contato ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>
    <main>
        <div class="titulo-bg">
            <div class="titulo container">
                <p class="font-2-l-b cor-5">Respostas em 24h</p>
                <h1 class="font-1-xxl cor-0">nosso contato<span class="escuro3">.</span></h1>
            </div>
        </div>

        <div class="contato container">
            <section class="contato-dados" aria-label="Endereço">
                <h2 class="font-1-m cor-0">Loja online</h2>
                <div class="contato-endereco font-2-s cor-4">
                    <p>R Quinto dos Inferno, 42 - Botafogo</p>
                    <p>Rio de Janeiro - RJ
                    </p>
                    <p>Brasil - Terra - Via Láctea</p>
                </div>
                <address class=" contato-meios font-2-s cor-4">
                    <a href="mailto:contato@dealsriders.com">contato@dealsriders.com</a>
                    <a href="mailto:assistencia@dealsriders.com">assistencia@dealsriders.com</a>
                    <a href="tel:+552199999999">+55 21 9999-9999</a>
                </address>
                <div class="contato-redes">
                    <a href="./">
                        <img src="./imgs/icones/laranjas/instagram.svg" alt="">
                    </a>
                    <a href="./">
                        <img src="./imgs/icones/laranjas/facebook.svg" alt="">
                    </a>
                    <a href="./">
                        <img src="./imgs/icones/laranjas/youtube.svg" alt="">
                    </a>
                </div>
            </section>

            <section class="contato-formulario" aria-label="Formulário">
                <form class="form" action="./contato.html">
                    <div>
                        <label for="nome">Nome</label>
                        <input type="text" id="nome" name="nome" placeholder="Seu nome">
                    </div>
                    <div>
                        <label for="telefone">Nome</label>
                        <input type="text" id="telefone" name="telefone" placeholder="(21) 9999-9999">
                    </div>
                    <div class="col-2">
                        <label for="email">Email</label>
                        <input type="email" id="email" name="email" placeholder="contato@email.com">
                    </div>
                    <div class="col-2">
                        <label for="mensagem">Mensagem</label>
                        <textarea rows="5" id="mensagem" name="mensagem" placeholder="O que você precisa?"></textarea>
                    </div>
                    <button class="btn-escuro col-2">Enviar mensagem</button>
                </form>
            </section>
        </div>
    </main>

    <article class="loja container">
        <h2 class="font-1-xxl">Lojas locais<span class="escuro2">.</span></h2>
        <div class="loja-item">
            <img src="./imgs/lojas/RJ.jpg" alt="mapa marcando o endereço em Rua Quinto dos inferno, 42 - Botafogo - RJ">
            <div class="loja-conteudo">
                <h3 class="font-1-xl">Rio de Janeiro</h3>
                <div class="loja-dados font-2-s cor-8">
                    <p>R Quinto dos Inferno, 42</p>
                    <p>Botafogo - RJ</p>
                </div>
                <div class="loja-dados font-2-s cor-8">
                    <a href="mailto:rj@dealsriders.com">rj@dealsriders.com</a>
                    <a href="tel:+552199999999">+55 21 9999-9999</a>
                </div>
                <p class="loja-tempo font-2-s"> <img src="./imgs/icones/laranjas/horario.svg" alt="">08-18h de seg à dom</p>
            </div>
        </div>

        <div class="loja-item">
            <img src="./imgs/lojas/SP.jpg" alt="mapa marcando o endereço em Rua sem criatividade, 42 - Republica - SP">
            <div class="loja-conteudo">
                <h3 class="font-1-xl">São Paulo</h3>
                <div class="loja-dados font-2-s cor-8">
                    <p>R Sem criatividade, 42</p>
                    <p>Republica - SP</p>
                </div>
                <div class="loja-dados font-2-s cor-8">
                    <a href="mailto:sp@dealsriders.com">sp@dealsriders.com</a>
                    <a href="tel:+551199999999">+55 11 9999-9999</a>
                </div>
                <p class="loja-tempo font-2-s"> <img src="./imgs/icones/laranjas/horario.svg" alt="">08-18h de seg à dom</p>
            </div>
        </div>
    </article>


<?php endwhile; else: endif ?>
<?php get_footer(); ?>
