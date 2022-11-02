<?php // Template Name: page-seguros ?>

<?php get_header(); ?>

<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>
    <main class="seguros-bg">
        <div class="titulo-bg">
            <div class="titulo container fadeInDown" data-anime="300">
                <p class="font-2-l-b cor-5">Escolha o seguro</p>
                <h1 class="font-1-xxl cor-0"> você seguro<span class="clara2">.</span></h1>
            </div>
        </div>


        <div class="seguros container">
            <div class="seguros-item fadeInLeft" data-anime="600">
                <h3 class="font-1-xl cor-6">SILVER</h3>
                <span class="font-1-xl cor-0">R$240 <span class="font-1-xs cor-6">mensal</span></span>

                <ul class="font-2-m cor-0">
                    <li>Revisões a semestrais</li>
                    <li>Assistência técnica</li>
                    <li>Suporte 08h às 18h</li>
                    <li>Cobertura estadual</li>
                </ul>
                <a href="<?php echo get_home_url(); ?>/orcamento?tipo=seguro&produto=silver" class="btn-escuro silver">Inscreva-se</a>
            </div>

            <div class="seguros-item fadeInRight" data-anime="900">
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
                <a href="<?php echo get_home_url(); ?>/orcamento?tipo=seguro&produto=gold" class="btn-claro">Inscreva-se</a>
            </div>
        </div>


    </main>

    <article class="vantagens-bg">
        <div class="vantagens container">
            <h2 class="font-1-xxl cor-0"> nossas vantagens<span class="clara2">.</span></h2>

            <ul>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/motor.svg" alt="">
                    <h3 class="font-1-l cor-0">Revisões</h3>
                    <p class="font-2-s cor-5">Garantimos o reparo completo caso ocorra algum problema inesperado, sabemos como é importante para sua segurança revisões constantes.</p>
                </li>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/carbono.svg" alt="">
                    <h3 class="font-1-l cor-0">Pintura</h3>
                    <p class="font-2-s cor-5">Caso ocorra algum imprevisto com a sua pintura, não se preocupe o seguro cobre batidas e arranhões.</p>
                </li>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/sustentavel.svg" alt="">
                    <h3 class="font-1-l cor-0">Sustentável</h3>
                    <p class="font-2-s cor-5">Trabalhamos com a filosofia de desperdício zero. Qualquer parte defeituosa é reciclada e reutilizada em outro projeto.</p>
                </li>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/rastreador.svg" alt="">
                    <h3 class="font-1-l cor-0">Recuperação</h3>
                    <p class="font-2-s cor-5">Para você poder dormir melhor, temos um GPS acoplado em sua moto, que funciona 24h por dia e em todo território nacional.</p>
                </li>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/seguro.svg" alt="">
                    <h3 class="font-1-l cor-0">Segurança</h3>
                    <p class="font-2-s cor-5">Junto do painel principal vem um sistema anti-furto que não permite clonagem do chip de sua chave, garantindo sua segurança.</p>
                </li>
                <li>
                    <img src="<?php echo get_template_directory_uri(); ?>/library/imgs/icones/amarelos/velocidade.svg" alt="">
                    <h3 class="font-1-l cor-0">Rapidez</h3>
                    <p class="font-2-s cor-5"> A liberdade que necessitavamos está na segurança e agilizade, cada moto nossa tem 159 cavalos de potência.</p>
                </li>
            </ul>
        </div>
    </article>

    <article class="perguntas container">
        <dl>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta1" aria-expanded="true">Qual forma de pagamento vocês aceitam?</button></dt>
                <dd class="font-2-s cor-9 ativa" id="pergunta1">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta2" aria-expanded="false">Como posso entrar em contato?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta2">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta3" aria-expanded="false">Vocês possuem algum desconto?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta3">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta4" aria-expanded="false">Qual a garantia que possuo?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta4">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta5" aria-expanded="false">Qual forma de pagamento vocês aceitam?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta5">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta6" aria-expanded="false">Quantas revisoes posso fazer ao ano?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta6">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
            <div>
                <dt><button class="font-1-m-b" aria-controls="pergunta7" aria-expanded="false">Qual modelo da riders devo escolher para o meu tamanho?</button></dt>
                <dd class="font-2-s cor-9" id="pergunta7">Aceitamos cartões de crédito com as bandeiras: Visa, Mastercard, ELO e American Express.
                    Para pagamentos à vista também aceitamos sua alma e Boleto através do PagSeguro.</dd>
            </div>
        </dl>
    </article>

<?php endwhile; else: endif ?>
<?php get_footer(); ?>
