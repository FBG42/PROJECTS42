<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'ranek-api' );

/** Database username */
define( 'DB_USER', 'root' );

/** Database password */
define( 'DB_PASSWORD', 'tiger' );

/** Database hostname */
define( 'DB_HOST', 'database' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'rO&W/te~6S($:$zs:3@<0&l<}mg;M%{lx}A4|Q^iI>F?t%PpFA*?EtI`4lAk.ZvZ' );
define( 'SECURE_AUTH_KEY',  'wqG|y7;AMukz:.srOz[+yQjO4cmlJa{ .[zl!>@M}z22PP/t{#:-Z9T/bRAijRg(' );
define( 'LOGGED_IN_KEY',    '/dIGc:B{Ck6YrRdnf,]=})XTBZ(hm?f$W^BJZ?Y=cB~Oq@3 Dlt|*g9)sqH:!bK=' );
define( 'NONCE_KEY',        's/A}Bk8flO$!Ny[hd_Ur1P~cKX[7yBqO]K:g8TiW[>4wePWG:Fu[dz97:X2R^Nx2' );
define( 'AUTH_SALT',        'lC1)A22=Iaif:,w{;y*X^8 *);]g pysWdfAjJpLsYz!.+cpk`0,trL~myq.>T-~' );
define( 'SECURE_AUTH_SALT', '4L,suPOp;;CScbs8Z6I`:^n;%Zb2jm7|HL=jSV@[QNpGTxm:xpBNm??O7jHsdzS<' );
define( 'LOGGED_IN_SALT',   'XD]?yVb97#Ib^)UC@KXdw.h|bBUtL|}f>fwtSRmoaGz}E+ukVc|Nuw gbQG> ;DX' );
define( 'NONCE_SALT',       '%F$5YA(EgW{BQ<xY.!dx?@a@,TYOsnmGTSE#|II[$<.:A8gMb9*=nwB94}NEu=h,' );
define('JWT_AUTH_SECRET_KEY', 's;gWga4xg6 SA/n9^F|n3?s%x1lY?7]MyVTx+-2VGj?{?xgAGc{Y,@&5*z,o?g.k');
define('JWT_AUTH_CORS_ENABLE', true);


/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';


