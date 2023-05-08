import { Router } from 'express';
import alunoController from '../controllers/AlunoController';

const router = new Router();

router.get('/', alunoController.index);

export default router;

/*
index -> lista todos os usuários -> GET
store/create -> cria um novo usuário -> POST
delete -> apaga um usuário -> DELETE
show -> mostra um usuário -> GET
update -> atualiza um usuário -> PATCH ou PUT
*/
