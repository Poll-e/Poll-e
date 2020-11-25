-- Adminer 4.7.7 PostgreSQL dump

CREATE SEQUENCE poll_option_images_id_seq INCREMENT 1 MINVALUE 1 MAXVALUE 2147483647 START 6 CACHE 1;

CREATE TABLE "public"."poll_option_images" (
    "id" integer DEFAULT nextval('poll_option_images_id_seq') NOT NULL,
    "name" text NOT NULL,
    "extension" text NOT NULL,
    "type" text NOT NULL,
    "data" bytea NOT NULL,
    CONSTRAINT "poll_option_images_id" PRIMARY KEY ("id")
) WITH (oids = false);


CREATE SEQUENCE poll_options_id_seq INCREMENT 1 MINVALUE 1 MAXVALUE 2147483647 START 4 CACHE 1;

CREATE TABLE "public"."poll_options" (
    "id" integer DEFAULT nextval('poll_options_id_seq') NOT NULL,
    "text" text NOT NULL,
    "image_id" integer NOT NULL,
    "poll_id" integer NOT NULL,
    CONSTRAINT "poll_options_id" PRIMARY KEY ("id"),
    CONSTRAINT "poll_options_image_id" UNIQUE ("image_id"),
    CONSTRAINT "poll_options_poll_id_text" UNIQUE ("poll_id", "text"),
    CONSTRAINT "poll_options_image_id_fkey" FOREIGN KEY (image_id) REFERENCES poll_option_images(id) NOT DEFERRABLE,
    CONSTRAINT "poll_options_poll_id_fkey" FOREIGN KEY (poll_id) REFERENCES polls(id) NOT DEFERRABLE
) WITH (oids = false);


CREATE SEQUENCE polls_id_seq INCREMENT 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1;

CREATE TABLE "public"."polls" (
    "id" integer DEFAULT nextval('polls_id_seq') NOT NULL,
    "code" text NOT NULL,
    "category" text NOT NULL,
    "title" text NOT NULL,
    CONSTRAINT "polls_code" UNIQUE ("code"),
    CONSTRAINT "polls_id" PRIMARY KEY ("id")
) WITH (oids = false);


CREATE SEQUENCE votes_id_seq INCREMENT 1 MINVALUE 1 MAXVALUE 2147483647 START 5 CACHE 1;

CREATE TABLE "public"."votes" (
    "id" integer DEFAULT nextval('votes_id_seq') NOT NULL,
    "likes" boolean NOT NULL,
    "nickname" text NOT NULL,
    "option_id" integer NOT NULL,
    CONSTRAINT "votes_id" PRIMARY KEY ("id")
) WITH (oids = false);


-- 2020-11-25 15:00:07.470711+00
