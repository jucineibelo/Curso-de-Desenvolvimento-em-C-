
CREATE TABLE public.Estado (
                estado_id INTEGER NOT NULL,
                uf CHAR(2) NOT NULL,
                nome VARCHAR(200) NOT NULL,
                CONSTRAINT pk_pessoa PRIMARY KEY (estado_id)
);
COMMENT ON TABLE public.Estado IS 'Entidade estado';
COMMENT ON COLUMN public.Estado.estado_id IS 'Chave primaria estado';
COMMENT ON COLUMN public.Estado.uf IS 'Uf do estado';
COMMENT ON COLUMN public.Estado.nome IS 'Nome do estado';


CREATE TABLE public.Cidade (
                cidade_id INTEGER NOT NULL,
                nome VARCHAR(200) NOT NULL,
                estado_id INTEGER NOT NULL,
                CONSTRAINT pk_cidade PRIMARY KEY (cidade_id)
);
COMMENT ON TABLE public.Cidade IS 'Entidade cidade';
COMMENT ON COLUMN public.Cidade.cidade_id IS 'Chave primaria da cidade';
COMMENT ON COLUMN public.Cidade.nome IS 'Nome da cidade';
COMMENT ON COLUMN public.Cidade.estado_id IS 'Chave primaria estado';


CREATE TABLE public.Pessoa (
                pessoa_id INTEGER NOT NULL,
                nome VARCHAR(200) NOT NULL,
                cpfcnpj VARCHAR(20),
                endereco VARCHAR(200),
                bairro VARCHAR(200),
                telefone VARCHAR(20),
                email VARCHAR(200),
                tipo CHAR DEFAULT 0,
                cidade_id INTEGER,
                CONSTRAINT pk_pessoa PRIMARY KEY (pessoa_id)
);
COMMENT ON TABLE public.Pessoa IS 'entidade Pessoa';
COMMENT ON COLUMN public.Pessoa.pessoa_id IS 'Identificador da pessoa';
COMMENT ON COLUMN public.Pessoa.nome IS 'Nome da pessoa';
COMMENT ON COLUMN public.Pessoa.cpfcnpj IS 'Cpf ou cnpj da pessoa';
COMMENT ON COLUMN public.Pessoa.endereco IS 'Endereço da pessoa';
COMMENT ON COLUMN public.Pessoa.bairro IS 'Bairro da pessoa';
COMMENT ON COLUMN public.Pessoa.telefone IS 'Telefone da pessoa';
COMMENT ON COLUMN public.Pessoa.email IS 'E-mail da pessoa';
COMMENT ON COLUMN public.Pessoa.tipo IS 'Tipo da pessoa: 0 - fisica, 1 - juridica';
COMMENT ON COLUMN public.Pessoa.cidade_id IS 'Chave primaria da cidade';


CREATE SEQUENCE public.conta_conta_id_seq;

CREATE TABLE public.Conta (
                conta_id INTEGER NOT NULL DEFAULT nextval('public.conta_conta_id_seq'),
                descricao VARCHAR(200) NOT NULL,
                valor NUMERIC(15,2) NOT NULL,
                dataVencimento TIMESTAMP,
                situacao CHAR DEFAULT 0 NOT NULL,
                dataPagamento TIMESTAMP,
                tipo CHAR DEFAULT 0 NOT NULL,
                pessoa_id INTEGER NOT NULL,
                CONSTRAINT pk_conta PRIMARY KEY (conta_id)
);
COMMENT ON TABLE public.Conta IS 'Tabela pra armazenar os dados de conta';
COMMENT ON COLUMN public.Conta.conta_id IS 'Chave primaria da tabela conta';
COMMENT ON COLUMN public.Conta.descricao IS 'Descrição da conta';
COMMENT ON COLUMN public.Conta.valor IS 'Valor da conta';
COMMENT ON COLUMN public.Conta.dataVencimento IS 'Data de vencimento da conta';
COMMENT ON COLUMN public.Conta.situacao IS 'Situação da conta: 0 - aberto, 1 - pago';
COMMENT ON COLUMN public.Conta.dataPagamento IS 'Data de pagamento da conta';
COMMENT ON COLUMN public.Conta.tipo IS 'Tipo da conta: 0 - pagar, 1 - receber';
COMMENT ON COLUMN public.Conta.pessoa_id IS 'Identificador da pessoa';


ALTER SEQUENCE public.conta_conta_id_seq OWNED BY public.Conta.conta_id;

ALTER TABLE public.Cidade ADD CONSTRAINT estado_cidade_fk
FOREIGN KEY (estado_id)
REFERENCES public.Estado (estado_id)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE public.Pessoa ADD CONSTRAINT cidade_pessoa_fk
FOREIGN KEY (cidade_id)
REFERENCES public.Cidade (cidade_id)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE public.Conta ADD CONSTRAINT pessoa_conta_fk
FOREIGN KEY (pessoa_id)
REFERENCES public.Pessoa (pessoa_id)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;
