<?php // Template Name: page-termos ?>

<?php get_header(); ?>
<?php if ( have_posts() ) : while ( have_posts() ) : the_post(); ?>

    <main>
        <div class="titulo-bg">
            <div class="titulo container">
                <p class="font-2-l-b cor-5">Termos de uso</p>
                <h1 class="font-1-xxl cor-0">Termos e Condições<span class="escuro3">.</span></h1>
            </div>
        </div>

        <div class="termos container cor-11">
            <h2 class="font-1-l cor-12">1. Termos de devolução.</h2>
            <p class="font-2-s"> 1.1 Ao concordar com estes termos, você estará concordando em vender a sua alma para a deals riders.<br>
                OBS: Não haverá qualquer tipo de devolução; uma vez vendida, a alma não poderá ser retransferida ao dono original.</p>

            <p class="font-2-s">1.2 Daqui a 10 anos a partir da data do concordamento destes termos, um dos cães do inferno irá
                surgir atrás de você para cobrar a bendita alma.</p>

            <p class="font-2-s">1.3 Durante estes 10 anos você receberá uma maré de sorte impressindível, trevos de quatro folhas, oportunidades inimagináveis.</p>

            <p class="font-2-s">1.4 Tendo a sorte como sua amiga durante um tempo, não vá gastar tempo atoa, aproveite, após sua alma ser coletada na terra você ficará uma eternidade no inferno.<br>

                OBS: O tempo corre de forma diferente lá embaixo, cada ano terrestre são 30 anos no inferno, cada 30 dias terrestre são 90 dias queimando, cada 24 horas terrestres são 48 horas agonizando.</p>

            <h2 class="font-1-l cor-11">2. Just kidding!(?)</h2>
            <p class="font-2-s"> 2.1 Está é apenas um crítica as vezes que concordamos ao com os termos dos softwares proprietários sem se quer ler as condições. </p>

            <p class="font-2-s">2.2 Recomendo um artigo do tecmundo sobre, que me inspirou a este “easter egg”.</p>

            <p class="font-2-s">2.3 https://www.tecmundo.com.br/consumidor/10206-contrato-de-licenca-concordou-e-nao-leu-sua-alma-voce-vendeu.htm</p>

            <h2 class="font-1-l cor-11">3. Academic way</h2>

            <p class="font-2-s"> 3.1 Este site foi criado por pura vontade acadêmica, sem intenção de ferir indiretamente nenhuma religiâo ou indivíduo, sendo criado apenas em HTML,CSS(Utilizando CSS utilitário) e JS Basíco.</p>

            <p class="font-2-s"> 3.2 Site criado durante o curso da Origamid, HTML e CSS para iniciantes.</p>

            <p class="font-2-s"> 3.3 Sendo o primeiro de vários sites criados por intençõe acadêmica que terão easter egg =)</p>
        </div>
    </main>

<?php endwhile; else: endif ?>
<?php get_footer(); ?>
