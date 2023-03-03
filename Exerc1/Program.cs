using turma;

Aluno Manu = new Aluno("Emanuelly", "127.239.369-02", "15/03/2004", 0,0,0,0);

Manu.GetFaltas();
Manu.Faltou(1);
Manu.GetFaltas();
Manu.SetNota(47.1,93.7);
Manu.FoiAprovado();
Manu.GetMedia();